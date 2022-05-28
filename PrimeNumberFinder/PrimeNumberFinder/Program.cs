using System;
using static System.Console;
using System.Collections.Generic;
//By Mike Berg
namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Prime Number Finder Program. \nEnter your starting number:  ");
            string numStart = ReadLine();
            int startNumIn = int.Parse(numStart);//don't be a ding dong and input a string
            

            WriteLine("Enter your ending number:  ");
            string numEnd = ReadLine();
            int endNumIn = int.Parse(numEnd);

            int[] arr = new int[endNumIn - startNumIn + 1];
            List<int> primes = new List<int>();

            for (int i = 0; i <= endNumIn - startNumIn; ++i)
            {
                arr[i] = startNumIn + i;
            }

            WriteLine("Original Array values:  ");
            Display(arr);
            WriteLine();
            WriteLine("Prime Numbers in array:  ");
            primes = Check_Prime(arr, endNumIn);
            primes.ForEach(p => Write($"{p} ")); //this uses the ForEach method in the list class and the nice lambda expression
            WriteLine();

        }
        
        private static List<int> Check_Prime(int[] numArr, int numEnd)//takes array input and ending number input. the ending
        //number is important because the for loop below will generate numbers from 1 to the end number
        {            
            List<int> primeArray = new List<int>();//the array where prime numbers will be added
            for (int i = 0; i < numArr.Length; i++)//iterates through each index position in the array
            {
                int a = 0;// this stores how many factors are found
                for (int j = 1; j <= numEnd; j++)//this generates numbers from 1 up to numEnd
                {                    
                    if (numArr[i] % j == 0)//most important piece of code. i represents the index positon which returns the number value.
                    //j is all the numbers from 1 to the end number. modulus is used to find factors. if a number has more than 2 factors
                    //then it is not a prime number. for instance, 11 is a prime because it is divisible by 1 and itself. 10 is not a prime
                    //because it is a composite number, meaning you can get to 10 by doing 2 x 5.
                    {
                        a++;
                    }                    
                }
                if (a == 2)//checks if there are only 2 factors
                {
                    primeArray.Add(numArr[i]);//adds number to prime array if there are only 2 factors
                }
            }
            return primeArray;
        }
        private static void Display(int[] arr)
        {
            foreach (int i in arr)
            {
                Write($"{i} ");
            }
        }       
    }
}