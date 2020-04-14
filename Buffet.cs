using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Buffet
    {
         public List<Food> Menu;
            public static Random random= new Random();
            public Buffet()
            {
                Menu=new List<Food>()
                {
                    new Food("Pizza", 800, false, false),
                    new Food("Chili", 256, true, false),
                    new Food("Sweet and Spicy Chicken", 550, true, true),
                    new Food("Pan Fried Pork Gyoza", 310, false, false),
                    new Food("Sushi Rolls", 200, false, false),
                    new Food("Wasabi", 10, true, false),
                    new Food("Mochi", 100, false, true),
                };
            }
            public Food Serve()
            {
                return Menu[random.Next(Menu.Count)];
            }
    }
}