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
        private int a_121;
        private int b_121;
        private int c_121;
        public HeSo() { }
        public HeSo(int a_121, int b_121, int c_121) {
            this.a_121 = a_121;
            this.b_121 = b_121;
            this.c_121 = c_121;
        }

        public int A { get => a_121; set => a_121 = value; }
        public int B { get => b_121; set => b_121 = value; }
        public int C { get => c_121; set => c_121 = value; }


        public double Delta(int a_121, int b_121, int c_121)
        {

            return b_121 * b_121 - 4 * a_121*c_121;
        }
        public void Nghiem(int a_121, int b_121, int c_121) {
            double del_121 = Delta(a_121, b_121, c_121); 
            if (del_121 == 0)
                Console.WriteLine("PT 1 nghiem x: {0}", -b_121 / 2*a_121);
            else if (del_121 > 0)
            {
                double x1_121 = (-b_121 + Math.Sqrt(del_121)) / (2 * a_121);
                double x2_121 = (-b_121 - Math.Sqrt(del_121)) / (2 * a_121);
                Console.WriteLine("x1 = {0}",x1_121);
                Console.WriteLine("x2 = {0}",x2_121);
            }
            else
                Console.WriteLine("PT vo nghiem");

        }
    }
}
