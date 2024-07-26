using homework1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Models
{
    public class HotMealsViewModel
    {
        public static List<HotMeal> HotMeals { get; set; } = new List<HotMeal>
{
    new HotMeal
    {
        Id = 1,
        Name = "Pizza Margaritta",
        Description = "Classic Italian Margaritta pizza with cheese and pomidor.",
        Price = 10.99
    },
    new HotMeal
    {
        Id = 2,
        Name = "Pizza Pepperoni",
        Description = "Classic Italian Pepperoni pizza with cheese ,sousage and pomidor.",
        Price = 12.99
    },
    new HotMeal
    {
        Id = 3,
        Name = "Pizza 4 cheese",
        Description = "Classic Italian Margaritta pizza with 4 different cheeses",
        Price = 13.49
    },
};


    }
}
