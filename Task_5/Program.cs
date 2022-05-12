using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Daniil";
            string lastName = "Gorin";
            string temporaryName;

            Console.WriteLine(firstName + " " + lastName);

            temporaryName = firstName;
            firstName = lastName;
            lastName = temporaryName;

            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
