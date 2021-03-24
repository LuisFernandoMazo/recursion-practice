using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
     
/*. Write a program in C# to find the sum of digits of a number using recursion. Go to the editor
	Test Data : 
	Input any number to find sum of digits: 25 
	Expected Output :

	The Sum of digits of 25 = 7 */
    class Exercise2
    {

        public int N;
        public int SumDigit(int Number)
        {
            if (Number == 0)
            {
                return Number;
            }
            else
            {
                N = ((Number % 10) + SumDigit(Number / 10));
            }

            return N;
       
        }
    }
}
