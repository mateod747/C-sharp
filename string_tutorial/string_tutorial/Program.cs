using System;
using System.Text;

namespace string_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "I'm \"smart\"!";
            Console.WriteLine(firstString);

            string secondString = "First line\nSecond line";
            Console.WriteLine(secondString);

            string thirdString = "Slash \\";
            Console.WriteLine(thirdString);

            string fourthString = @"Slash \";
            Console.WriteLine(fourthString);

            //string myString = String.Format("{0} = {1}", "1", "uno");
            //string myString = String.Format("{0:C}", 99.99);
            //string myString = String.Format("{0:N}", 134567890);
            //string myString = String.Format("Percentage: {0:P}", .555);
            //string myString = String.Format("Phone Number: {0:(####)## #######}", 385953938168);

            string myString = "  Ran up twenty million, told the Devil, \"Keep the luck\"  ";

            //myString = myString.Substring(41, 15);
            //myString = myString.Replace("  ", "--");
            //myString = myString.ToUpper();

            //myString = String.Format("Length before trim: {0} -- Length after trim: {1}", myString.Length, myString.Trim().Length);

            StringBuilder newString = new StringBuilder();

            for(int i = 0; i < 23; i++)
            {
                myString += "--" + (i * 2).ToString();
                newString.Append("--");
                newString.Append(i * 2);
            }

            Console.WriteLine(myString);
            Console.WriteLine(newString);
        }
    }
}
