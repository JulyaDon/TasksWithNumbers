using System;

namespace TasksWithNumbers.Tasks
{
    public static class TwoDimensions
    {
        public static void Arrange()
        {
            const int size = 10;
            int[,] array = new int[size, size];
            for(int i = 0, j = 0; i < size && j < size; i++, j++)
            {
                array[i, j] = 0;
            }

            Draw(array, size);
            Console.WriteLine();
            Clear(array, size);
            Draw(HorizontalHalf(array, size), size);
            Console.WriteLine();
            Clear(array, size);
            Draw(VerticalHalf(array, size), size);
            Console.WriteLine();
            Clear(array, size);
            Draw(Diagonal(array, size), size);
            Console.WriteLine();
            Clear(array, size);
            Draw(FilledDiagonal(array, size), size);
            Console.WriteLine();
            Clear(array, size);
            Draw(TwoFilledDiagonals(array, size), size);
            Console.WriteLine();
            Clear(array, size);
            Draw(TwoUnFilledDiagonals(array, size), size);
        }

        private static int[,] Clear(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = 0;
                }
            }
            return array;
        }

        private static void Draw(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] HorizontalHalf(int[,] array, int size)
        {
            int[,] hHalfArray = array;
            for (int i = 0; i < size/2; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    hHalfArray[i, j] = 2;
                }
            }
            return hHalfArray;
        }

        private static int[,] VerticalHalf(int[,] array, int size)
        {
            int[,] vHalfArray = array;
            for (int i = 0; i < size; i++)
            {
                for (int j = size/2; j < size; j++)
                {
                    vHalfArray[i, j] = 1;
                }
            }
            return vHalfArray;
        }

        private static int[,] Diagonal(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i == j) { 
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }

        private static int[,] FilledDiagonal(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i >= j)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }

        private static int[,] TwoFilledDiagonals(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j || i >= size-j-1)
                    { 
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }

        private static int[,] TwoUnFilledDiagonals(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j && i >= size - j - 1)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }
    }
}
