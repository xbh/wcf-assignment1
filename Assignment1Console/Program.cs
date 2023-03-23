using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Console {
    internal class Program {
        static void Main(string[] args) {
            var client = new ServiceReferenceWCF.ServiceClient();
            while (true)
            {
                int option = DisplayMenu();

                try {
                    if (option == 1) {
                        Console.WriteLine("Please input a number:");
                        var op = client.PrimeNumber(int.Parse(Console.ReadLine()));
                        Console.WriteLine(op + "\n");
                    } else if (option == 2) {
                        Console.WriteLine("Please input a number:");
                        var op = client.SumOfDigits(int.Parse(Console.ReadLine()));
                        Console.WriteLine(op + "\n");
                    } else if (option == 3) {
                        Console.WriteLine("Please input a string:");
                        var op = client.ReverseString(Console.ReadLine());
                        Console.WriteLine(op + "\n");
                    } else if (option == 4) {
                        Console.WriteLine("Please input a tag:");
                        var tag = Console.ReadLine();
                        Console.WriteLine("Please input a data:");
                        var data = Console.ReadLine();
                        var op = client.PrintHtmlTags(tag, data);
                        Console.WriteLine(op + "\n");
                    } else if (option == 5) {
                        Console.WriteLine("Please input a type:");
                        var type = Console.ReadLine();
                        Console.WriteLine("Please input an array, separate values with ',' :");
                        var data = Console.ReadLine();
                        var arr = client.SortNumbers(type, Array.ConvertAll(data.Split(','), int.Parse));
                        Console.WriteLine("{0}\n", string.Join(",", arr));
                    } else if (option == 6) {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                    }
                } catch (Exception) {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        static int DisplayMenu()
        {
            Console.WriteLine("         WCF Assignment 1");
            Console.WriteLine("1. Prime number");
            Console.WriteLine("2. Sum of digits");
            Console.WriteLine("3. Reverse a string");
            Console.WriteLine("4. Print HTML tags");
            Console.WriteLine("5. Sort 5 numbers");
            Console.WriteLine("6. Exit");
            Console.Write("     Enter your choice: ");
            var ip = Console.ReadLine();
            Console.Clear();
            try
            {
                return int.Parse(ip);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
