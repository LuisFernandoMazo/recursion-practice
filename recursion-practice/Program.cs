using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
    class Program
    {
         static void Main(string[] args)
        {
            Exercise3 e = new Exercise3();
            Exercise1 e1 = new Exercise1();
            Exercise2 e2 = new Exercise2();
           
            e.Primenum(12);
            e1.SumExercise(10);
            e2.SumDigit(122);

            Console.WriteLine("The sum of the numbers is " + e1.Result);
            Console.WriteLine("The sum of the numbers is " + e2.N);
        }
    }
}
    