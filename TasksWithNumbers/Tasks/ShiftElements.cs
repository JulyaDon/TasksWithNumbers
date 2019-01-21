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

            for(int j = 0; j < shift; j++) { 
                int temp = numbers[numbers.Length - 1];
                for (int i = numbers.Length-1; i >= 0; i--)
                {
                    if(i > 0)
                    {
                        numbers[i] = numbers[i - 1];
                    }
                    else numbers[0] = temp;
                }
            }

            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
