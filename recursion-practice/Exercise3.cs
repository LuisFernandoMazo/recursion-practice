using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
    class Exercise3
    {
     /*  3. Write a program in C to check a number is a prime number or not using recursion. Go to the editor
    Test Data : 
	Input any positive number : 7 
	Expected Output :
	The number 7 is a prime number.*/

        public int Primenum(int Num)
        {
            if(Num / 1 == Num && Num % 4 != 0)
            {
                Console.Write("The " + Num + "is a prime number");
                return Num;
            }
            else
            {
                Console.WriteLine("The " + Num + " isn't a prime number");
                return Num;
            }
        }
    }
}
