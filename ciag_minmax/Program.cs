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
            
            
            Console.ReadKey();
            int[] minMaxArray = FindMinMax(inputArray, arrLength);
        }
        static int[] FindMinMax(int[] inputArray, int arrLength)
        {
            int buffer = 0;
            SortTable(inputArray); //sortowanie par w tabeli rosnąco
            if (inputArray.Length == 2) return inputArray; //jeśli wyjściowa tabela ma 2 elementy, znaleźliśmy min i max
            int outputArrLength = arrLength / 2; //wyjściowa tablica po każdej rekurencji będzie miała 2 razy mniej elementów
            int[] outputArray = new int[outputArrLength];
            for(int i=0;i<arrLength; i=i+2)
            {
                
            }
        }
        static int[] SortTable(int[] inputArray)
        {
            int buffer = 0;
            for(int i=0;i<inputArray.Length;i=i+2)
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
