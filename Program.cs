using System;

namespace Add2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        // Skriva ett program (Console App)
            Console.WriteLine("/// ADD 2 NUMBERS ///");
        // som frågar användare att först skriva
        // in 2 tal i terminalen, för att
            Console.WriteLine("Please write 2 numbers");
            string Input1 = Console.ReadLine()!;
            int Number1 = Convert.ToInt32(Input1);
            string Input2 = Console.ReadLine()!;
            int Number2 = Convert.ToInt32(Input2);


        // programet ska addera de och skriva
        // ut resultatet i terminal.

            int NewNumber = Number1 + Number2;
            Console.WriteLine($"The sum of your numbers is: {NewNumber}");
            
        }
    }
}