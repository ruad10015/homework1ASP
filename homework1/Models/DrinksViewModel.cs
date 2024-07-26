using homework1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Models
{
    public class DrinksViewModel
    {
        public static List<Drink> Drinks { get; set; } = new List<Drink>()
        {
            new Drink
            {
                Id = 1,
                Name = "Coca-Cola",
                Price = 2,
                Description = "This is the coca cola",
            },
             new Drink
            {
                Id = 2,
                Name = "Fanta",
                Price = 2,
                Description = "This is the fanta",
            },
              new Drink
            {
                Id = 3,
                Name = "Coffee",
                Price = 0.8,
                Description = "This is the coffee",
            },
               new Drink
            {
                Id = 4,
                Name = "Milkshake",
                Price = 4.5,
                Description = "This is the Milkshake",
            },
                new Drink
            {
                Id = 5,
                Name = "Sprite",
                Price = 2,
                Description = "This is the Sprite ",
            }
        };
    }
}
