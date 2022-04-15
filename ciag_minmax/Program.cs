using System;
using System.Collections.Generic;

namespace ciag_minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile elementów ma mieć ciąg liczbowy?");
            int arrLength = int.Parse(Console.ReadLine());
            int length = arrLength;
            if (arrLength % 2 != 0) arrLength++;
            int[] inputArray = new int[arrLength];
            Random random = new Random();
            for(int i=0;i<length; i++)
            {
                inputArray[i] = random.Next(100);
            }
            if (arrLength != length) inputArray[arrLength - 1] = inputArray[length - 1]; 
            for(int j=0;j<arrLength;j++)
            {
                Console.Write($"{inputArray[j]} ");
            }
            Console.ReadKey();
        }
    }
}
