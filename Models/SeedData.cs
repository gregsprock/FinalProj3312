using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RazorPagesCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCarContext>>()))
            {
                // Look for any movies.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Make = "Honda",
                        Model = "Accord",
                        NumberOfDoors = 4,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 1, CustReviewDesc = "The door fell off"},
                            new Review {CustReview = 3}
                        }
                    },

                    new Car
                    {
                        Make = "Honda",
                        Model = "Civic",
                        NumberOfDoors = 2,
                        Cylinders = 4,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5, CustReviewDesc = "Amazing ride"},
                            new Review {CustReview = 4, CustReviewDesc = "Happy with purchase"}
                        }
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Expedition",
                        NumberOfDoors = 5,
                        Cylinders = 8
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Explorer",
                        NumberOfDoors = 5,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5, CustReviewDesc = "WOW!  Just WOW"},
                            new Review {CustReview = 4, CustReviewDesc = "Holds all the kids and their gear for practice"}
                        }
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Focus",
                        NumberOfDoors = 2,
                        Cylinders = 4,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 1},
                            new Review {CustReview = 1}
                        }
                    },

                    new Car
                    {
                        Make = "Lexus",
                        Model = "IS300",
                        NumberOfDoors = 4,
                        Cylinders = 8
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Impala",
                        NumberOfDoors = 4,
                        Cylinders = 8,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5, CustReviewDesc = "Loads of power"},
                            new Review {CustReview = 2, CustReviewDesc = "Gas guzzler"}
                        }
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Malibu",
                        NumberOfDoors = 2,
                        Cylinders = 6
                    },

                    new Car
                    {
                        Make = "Dodge",
                        Model = "Dart",
                        NumberOfDoors = 4,
                        Cylinders = 4
                    },

                    new Car
                    {
                        Make = "Jeep",
                        Model = "Wrangler",
                        NumberOfDoors = 2,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5, CustReviewDesc = "Dad is cool again"},
                            new Review {CustReview = 4, CustReviewDesc = "Only complaint is I wsh I had bought the hard top"}
                        }
                    },

                    new Car
                    {
                        Make = "Jeep",
                        Model = "Grand Cherokee",
                        NumberOfDoors = 5,
                        Cylinders = 8,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 1, CustReviewDesc = "The seat broke"},
                            new Review {CustReview = 4}
                        }
                    },

                    new Car
                    {
                        Make = "Honda",
                        Model = "Pilot",
                        NumberOfDoors = 5,
                        Cylinders = 6
                    },

                    new Car
                    {
                        Make = "Honda",
                        Model = "Odyssey",
                        NumberOfDoors = 5,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5},
                            new Review {CustReview = 4, CustReviewDesc = "Great fuel economy"},
                            new Review {CustReview = 5}
                        }
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "F-150",
                        NumberOfDoors = 4,
                        Cylinders = 8
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Silverado",
                        NumberOfDoors = 2,
                        Cylinders = 8,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5},
                            new Review {CustReview = 4, CustReviewDesc = "Surprising fuel economy for full size truck"},
                            new Review {CustReview = 5, CustReviewDesc = "Can't go wrong with chevy trucks"}
                        }
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Colorado",
                        NumberOfDoors = 4,
                        Cylinders = 6
                    },

                    new Car
                    {
                        Make = "Honda",
                        Model = "Ridgeline",
                        NumberOfDoors = 2,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 2},
                            new Review {CustReview = 1, CustReviewDesc = "Wannabe truck"},
                            new Review {CustReview = 2}
                        }
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Fiesta",
                        NumberOfDoors = 4,
                        Cylinders = 4,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 3},
                            new Review {CustReview = 1, CustReviewDesc = "Could this be any smaller???"},
                            new Review {CustReview = 5}
                        }
                    },

                    new Car
                    {
                        Make = "BMW",
                        Model = "325i",
                        NumberOfDoors = 4,
                        Cylinders = 6
                    },

                    new Car
                    {
                        Make = "Honda",
                        Model = "CR-V",
                        NumberOfDoors = 4,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5},
                            new Review {CustReview = 4},
                            new Review {CustReview = 5}
                        }
                    },

                    new Car
                    {
                        Make = "Honda",
                        Model = "Passport",
                        NumberOfDoors = 5,
                        Cylinders = 4
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Equinox",
                        NumberOfDoors = 5,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5, CustReviewDesc = "Nice car"},
                            new Review {CustReview = 4, CustReviewDesc = "Great fuel economy"},
                            new Review {CustReview = 5, CustReviewDesc = "Love it!!!"}
                        }
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Suburban",
                        NumberOfDoors = 6,
                        Cylinders = 8
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Tahoe",
                        NumberOfDoors = 5,
                        Cylinders = 8
                    },

                    new Car
                    {
                        Make = "Chevrolet",
                        Model = "Traverse",
                        NumberOfDoors = 5,
                        Cylinders = 6
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Taurus",
                        NumberOfDoors = 4,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5},
                            new Review {CustReview = 1, CustReviewDesc = "Should have got the SHO version"},
                            new Review {CustReview = 5}
                        }
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Fusion",
                        NumberOfDoors = 4,
                        Cylinders = 4,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5},
                            new Review {CustReview = 4, CustReviewDesc = "Quick little car"},
                            new Review {CustReview = 5}
                        }
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Mustang",
                        NumberOfDoors = 2,
                        Cylinders = 8
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Escape",
                        NumberOfDoors = 5,
                        Cylinders = 4
                    },

                    new Car
                    {
                        Make = "Ford",
                        Model = "Edge",
                        NumberOfDoors = 5,
                        Cylinders = 6,
                        Reviews = new List<Review>
                        {
                            new Review {CustReview = 5, CustReviewDesc = "The kids love it"},
                            new Review {CustReview = 4, CustReviewDesc = "Get all types of comments on this car!!"},
                            new Review {CustReview = 5}
                        }
                    }


                );
                context.SaveChanges();
            }
        }
    }
}