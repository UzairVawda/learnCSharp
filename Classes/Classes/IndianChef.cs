using System;
namespace Classes
{
    class IndianChef : Chef
    {
        public void MakeTandoor()
        {
            Console.WriteLine("Making Tandoor");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Making Special Dish: Egg Parm");
        }
    }
}

