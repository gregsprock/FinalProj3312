using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCar.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesCar.Pages_Cars
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCar.Models.RazorPagesCarContext _context;

        public IndexModel(RazorPagesCar.Models.RazorPagesCarContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Makes { get; set; }
        public SelectList Models { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CarMake { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CarModel { get; set; }
        public string noReviews { get; set; }
        public List<RazorPagesCar.Models.Review> Reviews {get; set;}
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int NumPages {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            IQueryable<string> makeQuery = _context.Car.OrderBy(m => m.Make).Select(m => m.Make);
            IQueryable<string> modelQuery = _context.Car.OrderBy(m => m.Model).Select(m => m.Model);

            var cars = _context.Car.Select(m => m);

            if (!string.IsNullOrEmpty(SearchString))
            {
                cars = cars.Where(s => s.Model.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CarMake))
            {
                cars = cars.Where(x => x.Make == CarMake);
            }

            if (!string.IsNullOrEmpty(CarModel))
            {
                cars = cars.Where(x => x.Make == CarMake && x.Model == CarModel);
            }
            Makes = new SelectList(await makeQuery.Distinct().ToListAsync());
            Models = new SelectList(await modelQuery.Distinct().ToListAsync());
            Car = await cars.Include(r => r.Reviews).ToListAsync();

            noReviews = "N/A";

            // var query = _context.Car.Select(p => p);

            switch (CurrentSort)
            {
                case "make_asc":
                    cars = cars.OrderBy(p => p.Make);
                    break;
                case "make_desc":
                    cars = cars.OrderByDescending(p => p.Make);
                    break;
                case "model_asc":
                    cars = cars.OrderBy(p => p.Model);
                    break;
                case "model_desc":
                    cars = cars.OrderByDescending(p => p.Model);
                    break;
            }

            var carCount = _context.Car.Count();
            decimal totPages = carCount % PageSize;
            if(totPages == 0)
            {
                NumPages = carCount / PageSize;
            }
            else {
                NumPages = (carCount / PageSize) + 1;
            }

            Car = await cars.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
