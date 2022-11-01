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

            //Console.WriteLine(bookOne.title);
            //Console.WriteLine(bookTwo.title);

            Student studentOne = new Student("Jane Doe", "CS", 3.5);
            Student studentTwo = new Student("John Doe", "ENG", 2.6);
            //Console.WriteLine(studentOne.HasHonors());
            //Console.WriteLine(studentTwo.HasHonors());

            Movie movieOne = new Movie("Jane Doe", "CS", "PG");
            Movie movieTwo = new Movie("John Doe", "ENG", "Dog");
            // G, PG, PG-13, R, NR
            Console.WriteLine(movieOne.Rating);
            Console.WriteLine(movieTwo.Rating);
        }
    }
}
