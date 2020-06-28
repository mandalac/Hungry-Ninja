using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet NinjasBuffet = new Buffet();
            Ninja David = new Ninja();
            while (David.IsFull == false)
            {
                David.Eat();
            }
            if (David.IsFull == true)
            {
                Console.WriteLine("The ninja is full");
            }
        }

        class Food
        {
            public string Name;
            public int Calories;

            public bool IsSpicy;
            public bool IsSweet;
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

            public Food(string name, int calories, bool isSpicy, bool isSweet)
            {
                Name = name;
                Calories = calories;
                IsSpicy = isSpicy;
                IsSweet = isSweet;
            }
        }

        class Buffet
        {
            public static List<Food> Menu;

            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Chicken", 1000, false, true),
                    new Food("Rice", 300, false, true),
                    new Food("Brokoli", 300, false, true),
                    new Food("Fish", 700, false, true),
                    new Food("Meatballs", 1100, false, true),
                    new Food("Bananna", 200, false, true),
                    new Food("Fries", 2000, false, true),
                };
            }

            public static Food Serve()
            {
                Random selectFood = new Random();
                int number = selectFood.Next(Menu.Count);
                return Menu[number];
            }
        }

        class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;

            public Ninja()
            {
                calorieIntake = 0;
                FoodHistory = new List<Food>();
            }

            public bool IsFull
            {
                get
                {
                    if (calorieIntake >= 1200)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            // build out the Eat method
            public void Eat()
            {
                if (calorieIntake >= 1200)
                {
                    Console.WriteLine("The ninja is full and can not eat anymore.");
                }
                else
                {
                    Food item = Buffet.Serve();
                    int calories = calorieIntake += item.Calories;
                    Console.WriteLine($"The ninja has {calories} calories");
                }
            }
        }







    }
}
