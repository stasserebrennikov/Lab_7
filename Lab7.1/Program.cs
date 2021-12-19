using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    internal class Program
    {
        public struct Triangle
        {
            public double a,b,c;
            public double Square ()
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt (p*(p-a)*(p-b)*(p-c));
                return s;       
            }
        }
        static void Main(string[] args)
        {
            Triangle [] triangles = new Triangle[2];
            for(int i = 0; i<triangles.Length; i++)
            {
                Console.WriteLine("Ввести значание длин (a,b,c) сторон треугольника {0}", i+1);
                triangles[i].a = double.Parse(Console.ReadLine());
                triangles[i].b = double.Parse(Console.ReadLine());
                triangles[i].c = double.Parse(Console.ReadLine());
            }
            for (int i = 0;i< triangles.Length; i++)
            {
                Console.WriteLine("Площадь {0} - го треугольника = {1}", i+1, triangles[i].Square());
            }
            int maxSquaredTriIdx = 0;
            for (int i = 0; i < triangles.Length; i++)
            {
                if (triangles[i].Square() > triangles[maxSquaredTriIdx].Square())
                    maxSquaredTriIdx = i;   
            }
            Console.WriteLine("Макс площадь у {0}-го треугольника", maxSquaredTriIdx+1);
            Console.ReadKey();  
        }
    }
}
