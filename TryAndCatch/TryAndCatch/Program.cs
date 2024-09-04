using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 0;
            
            try {
                int z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception ex){
                Console.WriteLine("error");
            }
        }
    }
}
