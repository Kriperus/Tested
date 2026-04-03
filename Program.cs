using System;

namespace ConsoleApplication18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enter numbers please: ");
            // int num1 = int.Parse(Console.ReadLine());
            // int num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Summ of your numbers: " + (num1  + num2));
            
            /*Console.WriteLine("Enter numbers please: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                num1 = num2;
            }
            
            Console.WriteLine("Higest number is: " + num1 + "and today is ");
            switch (num1)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Your number is incorrect"); break;
            }*/

            /*int result = 0, i = 0;
            for (i = 0; i <= 10; i++)
            {
                result += i;
            }

            i = 0;
            Console.WriteLine("Sum of numbers in cycle for: " + result);
            result = 0;

            while (i <= 10)
            {   
                result += i;
                i++;
            }
            
            i = 0;
            Console.WriteLine("Sum of numbers in cycle while: " + result);
            result = 0;

            do
            {
                result += i;
                i++;
            } while (i <= 10);
            Console.WriteLine("Sum of numbers in cycle do-while: " + result);*/
            
            int[] mass = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-100, 100);
                Console.Write(mass[i] + " ");
            }
            
            int[,] mass2 = new int[10, 10];
            for (int i = 0; i < mass2.GetLength(0); i++)
            {
                for (int j = 0; j < mass2.GetLength(1); j++)
                {
                    mass2[i, j] = rnd.Next(-100, 100);
                    Console.Write(mass2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}