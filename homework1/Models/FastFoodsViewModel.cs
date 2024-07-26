using homework1.Entities;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Models
{
    public class FastFoodsViewModel
    {
        public static List<FastFood> FastFoods { get; set; } = new List<FastFood>
{
    new FastFood
    {
        Name = "Cheeseburger",
        Description = "Juicy beef patty with melted cheese, lettuce, tomato, and pickles.",
        Price = 5.99,
    },
    new FastFood
    {
        Name = "Chicken Nuggets",
        Description = "Crispy breaded chicken nuggets served with your choice of dipping sauce.",
        Price = 4.49,
    },
    new FastFood
    {
        Name = "Fries",
        Description = "Crispy fries seasoned with salt.",
        Price = 2.99,
    },
    new FastFood
    {
        Name = "Döner",
        Description = "A döner is a Turkish dish of rotisserie-cooked meat, often served in bread.",
        Price = 3.49,
    },
    new FastFood
    {
        Name = "Hot Dog",
        Description = "A classic hot dog served in a bun with mustard and ketchup.",
        Price = 3.29,
    }
};

    }
}
