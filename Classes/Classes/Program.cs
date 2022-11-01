using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("The First Minute", "Uzair Vawda", 107);

            Book bookTwo = new Book("Loss of time", "Loss of time", 99);
            
            Console.WriteLine(bookOne.title);
            Console.WriteLine(bookTwo.title);
        }
    }
}
