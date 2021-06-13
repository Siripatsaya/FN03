using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {

            int Number = int.Parse(Console.ReadLine());
            double[] collection = new double[0];
            PrintOutput(collection);
        }

        static void PrintOutput(double[] collection)
        {
            string isEnded = "End";
            while (isEnded == "End")
            {
                string input = Console.ReadLine();
                if (input == "FindMax")
                {
                    FindMax(collection);
                }
                else if (input == "FindMin")
                {
                    FindMin(collection);
                }
                else if (input == "FindMean")
                {
                    FindMean(collection);
                }
                else
                {
                    Console.WriteLine("Invalid mode");
                }
            }
        }
        static double FindMax(double[] collection)
        {
            double max = collection[0];
            foreach (double num in collection)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static double FindMin(double[] collection)
        {
            double min = collection[0];
            foreach (double num in collection)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static double FindMean(double[] collection)
        {
            double sum = 0, avg;
            double mean = collection.Length;
            foreach (double num in collection)
            {
                sum += num;
            }
            avg = sum / mean;
            return avg;
        }
    }
}
