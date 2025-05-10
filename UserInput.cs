using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q2.Hello world With user input
namespace P2_UserInput_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hello : ");
            string s = Console.ReadLine();

            Console.WriteLine($"{s} World !");
        }
    }
}
