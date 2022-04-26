using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class HeSo {
        private int a;
        private int b;
        private int c;
        public HeSo() { }
        public HeSo(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }


        public double Delta(int a, int b, int c)
        {

            return b * b - 4 * a*c;
        }
        public void Nghiem(int a, int b, int c) {
            double del = Delta(a, b, c); 
            if (del == 0)
                Console.WriteLine("PT 1 nghiem x: {0}", -b / 2*a);
            else if (del > 0)
            {
                double x1 = (-b + Math.Sqrt(del)) / (2 * a);
                double x2 = (-b - Math.Sqrt(del)) / (2 * a);
                Console.WriteLine("x1 = {0}",x1);
                Console.WriteLine("x2 = {0}",x2);
            }
            else
                Console.WriteLine("PT vo nghiem");

        }
    }
}
