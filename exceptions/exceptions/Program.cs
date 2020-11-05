using System;
using System.IO;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string quote = File.ReadAllText(@"C:\Users\mateodubinjak\Desktop\example.txt");
                Console.WriteLine(quote);
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
