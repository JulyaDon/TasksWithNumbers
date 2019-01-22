using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithNumbers.Tasks
{
    public static class FizzBuzz
    {
        public static void Execute()
        {
            for (int i = 1; i < 100; i++)
            {
                String text = "";
                text += (i % 3) == 0 ? "Fizz" : "";
                text += (i % 5) == 0 ? "Buzz" : "";
                Console.WriteLine(text == "" ? i.ToString() : text);
            }
        }
    }
}
