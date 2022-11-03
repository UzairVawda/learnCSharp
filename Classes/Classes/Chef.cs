using System;
namespace Classes
{
    public class Chef
    {
        public Chef()
        {
        }

        public void MakeSandwich()
        {
            Console.WriteLine("Making Sandwich");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Making Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Making Special Dish: Lamb");
        }
    }
}

