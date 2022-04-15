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
                inputArray[i] = random.Next(20);
            }
            
            if (arrLength != length) inputArray[arrLength - 1] = inputArray[length - 1];
            //int[] outputArray = SortTable(inputArray);
            
            for (int j = 0; j < arrLength; j++)
            {
                Console.Write($"{inputArray[j]} ");
            }
            inputArray=SortTable(inputArray);
            
            Console.ReadKey();
            int[] minMaxArray = FindMinMax(inputArray, arrLength);
            Console.WriteLine("\n");
            for(int i=0;i<minMaxArray.Length;i++)
            {
                Console.Write($"{minMaxArray[i]} ");
            }
            Console.ReadKey();
        }
        static int[] FindMinMax(int[] inputArray, int inputArrLength)
        {
            //sortowanie par w tabeli rosnąco
            inputArray=SortTable(inputArray);
            if (inputArrLength == 2) return inputArray;
            
            int outputArrIndex = 0;
            int outputArrLength = inputArrLength / 2;
            int[] outputArray = new int[outputArrLength];
            for (int i=0;i<inputArrLength-4;i+=4)
            {
                if (inputArray[i] < inputArray[i + 2]) outputArray[outputArrIndex] = inputArray[i];
                else outputArray[outputArrIndex] = inputArray[i + 2];
                if (inputArray[i+1] > inputArray[i + 3]) outputArray[outputArrIndex+1] = inputArray[i+1];
                else outputArray[outputArrIndex+1] = inputArray[i + 3];
                outputArrIndex += 2;
            }
            return FindMinMax(outputArray, outputArray.Length);
        }
        static int[] SortTable(int[] inputArray)
        {
            int buffer = 0;
            for(int i=0;i<inputArray.Length-1;i=i+2)
            {
                if(inputArray[i]>inputArray[i+1])
                {
                    buffer = inputArray[i];
                    inputArray[i] = inputArray[i + 1];
                    inputArray[i + 1] = buffer;
                }
               
            }
            return inputArray;
        }
    }
}
