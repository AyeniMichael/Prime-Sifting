using System;
using System.Collections.Generic;

namespace PrimeSift
{
    public class PrimeSift
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Prime Sifting");
            Console.WriteLine("Enter your number");
            string inputInteger = Console.ReadLine();
            int inputNumber  = int.Parse(inputInteger);
            Prime(inputNumber);
        }

        static void Prime(int inputNum)
        {
            List<int> primeNumbers = new List<int> {};

            for (int prime = 2; prime<=inputNum; prime++)
            {
                primeNumbers.Add(prime);

                if ((prime != 2 && prime%2 == 0) || (prime != 3 && prime%3 == 0) || (prime != 5 && prime%5  == 0) || (prime != 7 && prime%7 == 0) )
                {
                    primeNumbers.Remove(prime);
                }
                
            }

            Console.WriteLine("The prime numbers within the number you entered are: ");
            
            foreach(int number in primeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}