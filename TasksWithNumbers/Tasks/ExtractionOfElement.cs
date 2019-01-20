using System;

namespace TasksWithNumbers.Tasks
{
    public static class ExtractionOfElement
    {
        public static void Extract()
        {
            int[] numbers = new int[21];
            for (int i = 0; i <= 20; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine("Enter number from 0 to 20 that is to be removed: ");
            var removeN = Int32.Parse(Console.ReadLine());
            if (removeN >= 0 && removeN < 21)
            {
                for (int i = removeN; i < 20; i++)
                {
                    numbers[i] = numbers[i + 1];
                }

                numbers[20] = 0;
            }
            else
            {
                Console.WriteLine("Number is invalid");
            }

            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
