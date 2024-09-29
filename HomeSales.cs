using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO.Compression;

namespace HomeSales;

class Program
{
    static void Main(string[] args)
    {
        int max = 0;
        int sumsale = 0;
        string maxsalesperson = "";
        for (; ; )
        {
            Console.Write("salesperson: ");
            string salesperson = Console.ReadLine();
            if (salesperson == "z" || salesperson == "Z")
            {
                break;
            }
            if ((salesperson != "F" && salesperson != "D" && salesperson != "E") && (salesperson != "f" && salesperson != "d" && salesperson != "e"))
            {
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
                continue;
            }
            Console.Write("sale: ");
            int sale = Convert.ToInt32(Console.ReadLine());
            sumsale = sumsale + sale;
            if (sale > max)
            {
                max = sale;
                maxsalesperson = salesperson;
            }
        }

        Console.WriteLine("Grand Total: " + sumsale);
        Console.WriteLine("Highest Sale: " + maxsalesperson);

    }
}
