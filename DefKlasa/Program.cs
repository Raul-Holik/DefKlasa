using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefKlasa
{
    class FoodType
    {
        private string name;
        private int protein, carbs, fat;
        static int counter=0;

        public FoodType()
        {
          counter++;
        }
        public string Name { get => name; }
        public int Protein { get => protein; }
        public int Carbs { get => carbs; }
        public int Fat { get => fat; }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }

        public override string ToString()
        {
            return name + "p- " + protein + " %, c- " + carbs + " %, f- " + fat + " %.";
        }

        static int getNumberOfCreatedInstances()
        {
            return counter;
        }
    }
    class Food
    {
        FoodType type;
        int weight;
        double protein, carbs, fat;
        public int Weight { get => weight; }
        public double Protein { get => protein;  }
        public double Carbs { get => carbs;  }
        public double Fat { get => fat;  }

        public Food(FoodType type, int weight, double protein, double carbs, double fat)
        {
            this.type = type;
            this.weight = weight;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }

        public override string ToString()
        {
            return  type+ " p- " +protein  + " g, c- " +carbs  + " g, f- " + fat + " g, w- "+weight+" g.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana ", 4, 93, 3);
            Food food = new Food(foodType, 110, 14, 17, 12);
            Console.WriteLine(food.ToString());

            Console.ReadKey();
        }
    }
}
