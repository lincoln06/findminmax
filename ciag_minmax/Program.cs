using System;
using System.Collections.Generic;

namespace ciag_minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak długi będzie wprowadzony ciąg liczbowy?");
            int length = int.Parse(Console.ReadLine());
            int steps = 0;
            if (length % 2 != 0)
            {
                steps = length;
                length++;
            }
            else steps = length;
            int[] array = new int[length];
            for(int i=0;i<steps;i++)
            {
                Console.WriteLine($"Podaj {i} wyraz ciągu: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            if (steps < length) array[length-1] = array[steps-1];

            Console.WriteLine("Wyświetlanie tablicy");
            for(int j=0;j<length; j++)
            {
                Console.Write($"{array[j]} ");
            }
            Console.ReadKey();
            Console.WriteLine("\n\n");
            int[] indexList = GroupTwoElements(array, length);
            for(int k=0;k<indexList.Length;k++)
            {
                Console.WriteLine(indexList[k]);
            }
            Console.ReadKey();

        }
        static int[] GroupTwoElements (int[] array, int length)
        {
            int index = 0;
            length = length / 2;
            int[] indexList = new int[length];
            for(int i=0;i<length;i++)
            {
                indexList[i] = index;
                index += 2;
            }
            return indexList;
        }
        
    }
}
