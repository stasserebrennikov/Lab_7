using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            x = y = z;
            int V, S;
            GetParam (x,z,y, out V, out S);
            Console.WriteLine(V);
            Console.WriteLine(S);
            Console.ReadKey();
        }
        static void GetParam(int x,int y,int z, out int V, out int S)
        {
            V = x*y*z; 
            S = 6*y*z;    
        }
        

    }
}
