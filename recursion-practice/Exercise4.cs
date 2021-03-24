using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_practice
{
 /*4. Spiderman is capable to jump one or two buildings
	0	|	|	|	|
	Spiderman b1  b2 b3  b4
    Spider could jump to b1, or b2.Once Spiderman has jumped to the b2, he could jump to the b3 or b4 buildings.
Spiderman is always able to jump 1 or 2 buildings.
How many ways has Spiderman to go up n buildings.
(e.g.)
    input
    n = 3*/
    class Exercise4
    {
        
        static void Main(string[] args)
        {
            int N=5;
            int Result = PossibleWays(N);
            Console.WriteLine("The possible ways to jump through each building are " + PossibleWays(Result));
        }

        public static int Spiderman(int Buil)
        {
            if (Buil <= 1)
            {
                return Buil;
            }
            return (Spiderman(Buil - 2) + Spiderman(Buil - 1));
        }

        static int PossibleWays(int Ways)
        {
            return Spiderman(Ways + 1);
        }
        
    }
}
