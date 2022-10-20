using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public delegate int Mydelegate(int num); 
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //anonymus function
            //Mydelegate obj = delegate (int a)
            //  {
            //      a += 5;
            //      Console.WriteLine(a);
            //  };

            //obj.Invoke(10);
            //Console.ReadLine();


            //Lambda Expression
            Mydelegate obj = (a)=>
              {
                  a += 5;
                  return(a);
              };

            Console.WriteLine(obj(50));
            Console.ReadLine();
        }
    }
}
