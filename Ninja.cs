using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Ninja
    {
        private int calorieIntake;
        private int calorieLimit;
        public List<Food> FoodHistory;
        public bool IsFull {
            get 
            {
                return calorieIntake>=calorieLimit;
            }
        }
        public Ninja()
        {
            calorieIntake = 0;
            calorieLimit = 1200;
            FoodHistory= new List<Food>();
        }



        public void Eat(Food item)
        {
            Console.WriteLine($"{item.Name} contains: {item.Calories} Calories");
            if(this.IsFull)
            {
                Console.WriteLine($"This Ninja is full and can't eat anymore. Their stomach has {this.calorieIntake} calories in it");
            }
            else
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine("The Ninja is now eating some " + item.Name);
                if (item.IsSpicy == true)
                {
                    Console.WriteLine("AHH! It's Spicy!");
                }
                if (item.IsSweet == true)
                {
                    Console.WriteLine("Yay! It's Sweet!");
                }
            }
        }
    }
}