using System;

namespace arrayNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1 ,2 ,3 , 4, 5 ,6 };
            string numbersOfString = string.Join(", ", numbers);
            int[] reversedNumbers = new int[numbers.Length];

            Console.WriteLine(numbersOfString);
            for (int i = 0; i < numbers.Length; i++)
            {
                reversedNumbers[numbers.Length - i - 1] = numbers[i];
                //reveresedNumbers[i] =  numbers[numbers.Length - i - 1];
            }
            numbersOfString = string.Join("\n", reversedNumbers);
            Console.WriteLine(numbersOfString);


        }
    }
}
