using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        private static int Start = 1;
        private static int end;
        public static int sum(int n)
        {
            end += Start;
            Start++;
            if (Start != n)
                sum(n);
            return n + end;
        }
        public static int Sum_Q1(int n)
        {
            return n*(n+1)/2;
        }

        public static int sum_For(int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
                total += i;
            return total;
        }


        public static int sum_While(int n)
        {
            int total = 0;
            int i = 1;
            while(i <= n)
            {
                total += i;
                i++;
            }
            return total;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("\nQuestion 1.1 :");
            for (int i = 1; i <= 100; i++)
                Console.Write(i + " - ");

            Console.WriteLine("\n Question 1.2 :");

            for (int i = 100; i >= 1; i--)
                Console.Write(i + " - ");

            Console.WriteLine("\n\nPlease enter n:");
            string n = Console.ReadLine();
            int number;
            Int32.TryParse(n, out number);


            Console.WriteLine("\n\n Question 1.4 :"+sum(number));

            Console.WriteLine("\n Question 1.5 For Loop :" + sum_For(number));

            Console.WriteLine("\n Question 1.5 While Loop :" + sum_While(number));

            Console.WriteLine("\n Question 1.5 Q(1): " + Sum_Q1(number));

            Console.ReadKey();
        }
    }
}
