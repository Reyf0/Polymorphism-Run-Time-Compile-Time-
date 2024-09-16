using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_1z
{
    public static class CustomConverter
    {
        public static void Convert(string a, out int b)
        {
            b = System.Convert.ToInt32(a);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string abc = "123";
            int n;
            CustomConverter.Convert(abc, out n);
            Console.WriteLine(n);
        }
    }
}
