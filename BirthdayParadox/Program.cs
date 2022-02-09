using System;

namespace BirthdayParadox
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random generator = new Random();
            int[,] matrix = new int[5,15];
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < 5; i++)
            { // for number of people
                int[] peoples = { 2, 3, 5, 10, 20 };
                if (i != 0) {
                    Console.WriteLine();
                }
                Console.WriteLine("Data for group of " + peoples[i] + ":");
                Console.WriteLine("The number of overlaps in the days of the week:");
                for (int j = 0; j < 15; j++)
                { // for number of experiment
                    int[] weekdays = { 0, 0, 0, 0, 0, 0, 0 };
                    Console.WriteLine(j + 1 + ".experiment:");
                    int total = 0;
                    for (int k = 0; k < peoples[i]; k++)
                    {
                        int number = generator.Next(7); // create number of 0-6
                        weekdays[number] += 1;
                    }
                    int a = 0;
                    foreach (int element in weekdays)
                    { // calculate the number of overlaps
                        if (element == 0)
                        {
                            Console.WriteLine(week[a] + ":" + element + " overlap");
                        }
                        else
                        {
                            total += element - 1;
                            Console.WriteLine(week[a] + ":" + (element - 1) + " overlap");
                        }
                        a += 1;
                    }
                    matrix[i,j] = total;
                }
            }
            Console.WriteLine("\nTotal number of overlaps in 15 experiment and 5 different people numnber:");
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine((b + 1) + ".people:");
                for (int y = 0; y < 15; y++)
                {
                    Console.WriteLine(matrix[b,y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}