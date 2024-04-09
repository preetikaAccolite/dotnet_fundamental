using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
           int a=Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the addition of the numbers is"+Add(a,b));
            Console.ReadLine();
        }
    }
}
