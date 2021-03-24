using System;

namespace recursion_practice
{
    class Exercise1
    {
        /* 1. Write a program in C# to calculate the sum of numbers from 1 to n using recursion. Go to the editor
        Test Data : 
        Input the last number of the range starting from 1 : 5 
        Expected Output :

        The sum of numbers from 1 to 5 : 
        15    */
       
        public int Result;
        public  int SumExercise(int Number)
        {
            
            if (Number == 1)
            {
                return (1);
            }
            else
            {
                Result = Number + SumExercise(Number - 1);
            }
            return (Result);
        }
    }
}
  