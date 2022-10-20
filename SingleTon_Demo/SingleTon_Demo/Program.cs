using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.CreateInstance();
            Console.ReadLine();
        }
    }
}
