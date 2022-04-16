using System;

namespace ciag_minmax
{
    class Program
    {
        static int numberOfFindOperations = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Ile elementów?");
            int arrLength = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] inputArray = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                inputArray[i] = random.Next(300);
                Console.Write($"{inputArray[i]}\t");
            }
            Console.WriteLine();

            Console.ReadKey();
            int[] outputArray = FindMinMax(inputArray);
            Console.WriteLine($"Ilość porównań: {numberOfFindOperations}");
            Console.WriteLine($"Element minimalny: {outputArray[0]}");
            Console.WriteLine($"Element maksymalny: {outputArray[1]}");
            Console.ReadKey();
        }
        static int[] FindMinMax(int[] inputArray)
        {
            inputArray = SortTable(inputArray);
            if (inputArray.Length == 2) return inputArray;

            if (inputArray.Length % 4 != 0) inputArray = AddMoreElements(inputArray);
            int[] outputArray = new int[inputArray.Length / 2];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i += 4)
            {
                outputArray[j] = FindMin(inputArray[i], inputArray[i + 2]);
                outputArray[j + 1] = FindMax(inputArray[i + 1], inputArray[i + 3]);
                j += 2;
            }
            return FindMinMax(outputArray);
        }

        static int[] SortTable(int[] inputArray)
        {
            int buffer = 0;
            for (int i = 0; i < inputArray.Length - 1; i = i + 2)
            {
                if (inputArray[i] > inputArray[i + 1])
                {
                    buffer = inputArray[i];
                    inputArray[i] = inputArray[i + 1];
                    inputArray[i + 1] = buffer;
                }

            }
            return inputArray;
        }
        static int FindMin(int a, int b)
        {
            numberOfFindOperations++;
            if (a > b) return b;
            return a;
        }
        static int FindMax(int a, int b)
        {
            numberOfFindOperations++;
            if (a > b) return a;
            return b;
        }
        static int[] AddMoreElements(int[] inputArray)
        {
            int outputArrLength = inputArray.Length;

            while (outputArrLength % 4 != 0)
            {
                outputArrLength++;
            }
            int[] outputArray = new int[outputArrLength];
            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            while (outputArrLength > inputArray.Length)
            {
                outputArray[outputArrLength - 1] = outputArray[inputArray.Length - 1];
                outputArrLength--;
            }
            return outputArray;
        }
    }
}
