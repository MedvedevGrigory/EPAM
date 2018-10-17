using System;

namespace Task1
{
    public static class WorkingWithArray
    {
        public static void FillRandom(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(200) - 100;
            }
        }

        public static void FillRandom(int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                        array[i, j] = rand.Next(200) - 100;
                }
            }
        }

        public static void FillRandom(int[,,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int l = 0; l < array.GetLength(2); l++)
                    {
                        array[i, j, l] = rand.Next(200) - 100;
                    }
                }
            }
        }

        public static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],3}  ");
            }

            Console.WriteLine();
        }

        public static void Output(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j],3}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void Output(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int l = 0; l < array.GetLength(2); l++)
                    {
                        Console.Write($"{array[i, j, l],4}  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static int SearchMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int SearchMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int[] Sort(int[] array)
        {
            int buff;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        buff = array[i];
                        array[i] = array[j];
                        array[j] = buff;
                    }
                }
            }

            return array;
        }

        public static int[,,] ReplacePositiveWith0(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int l = 0; l < array.GetLength(2); l++)
                    {
                        if (array[i,j,l] > 0)
                        {
                            array[i, j, l] = 0;
                        }
                        
                    }
                }
            }

            return array;
        }

        public static int SumNonnegativeElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int SumOfElementsOnEvenPositions(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0) 
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
