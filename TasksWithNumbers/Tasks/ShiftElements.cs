using System;

namespace TasksWithNumbers.Tasks
{
    public static class ShiftElements
    {
        public static void Shift()
        {
            int[] numbers = {1, 6, 8, 5, 0, -3, 2};
            Console.WriteLine("Enter shift: ");
            int shift = Convert.ToInt32(Console.ReadLine());
            int z = numbers.Length - shift;
            for (int i = 0; i < z; i++)
            {
                int temp = numbers[i + shift];
                numbers[i + shift] = numbers[i];
                //numbers[i] = temp;
            }

            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
