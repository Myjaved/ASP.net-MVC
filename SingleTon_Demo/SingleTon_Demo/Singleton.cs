using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Demo
{
    internal class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton instance;

        public static Singleton CreateInstance()
        {
            Console.WriteLine("This is my method");

            if (instance == null)
                instance = new Singleton();
            return instance;
            

        }
    }
}
