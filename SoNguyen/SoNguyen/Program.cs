using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_121 = new int[10];
            for(int i_121 = 0; i_121 < 10; i_121++)
            {
                Console.Write("Nhap a[{0}]: ", i_121 + 1);
                arr_121[i_121] = int.Parse(Console.ReadLine());
            }
            int max_121 = arr_121[0];
            int min_121 = arr_121[0];
            for (int i_121 = 0; i_121 < 10; i_121++)
            {
                if (max_121 < arr_121[i_121])
                    max_121 = arr_121[i_121];
                if (min_121 > arr_121[i_121])
                    min_121 = arr_121[i_121];
            }
            int[] xh_121 = new int[100];
            for (int i = 0; i < 10; i++)
                xh_121[i] = 0;
            for (int j = 0; j < 10; j++)
                xh_121[arr_121[i]]++;
            int maxXH_121 = xh_121[0];
            int csMax_121 = 0;
            for (int i_121 = 1; i_121 < 10; i_121++)
            {
                if (xh_121[i_121] > maxXH_121)
                {
                    csMax_121 = i_121;
                }

            }
            Console.WriteLine("Phan tu xuat hien nhieu nhat la: " + arr_121[csMax_121]);
            int a_121 = 0;
            for (int i_121 = 0; i_121 < 10; i_121++)
            {

                for (int j_121 = i_121; j_121 < 10; j_121++)
                    if (arr_121[i_121] < arr_121[j_121]) {
                        a_121 = arr_121[i_121];
                        arr_121[i_121] = arr_121[j_121];
                        arr_121[j_121] = a_121;
                    }
                        
                        
            }
            Console.Write("Chuoi giam dan: ");
            for (int i_121 = 0; i_121 < 10; i_121++) {
                
                Console.Write("{0} ", arr_121[i_121]);
                
            }
            Console.WriteLine();
            for (int i_121 = 0; i_121 < 10; i_121++)
            {

                for (int j_121 = i_121; j_121 < 10; j_121++)
                    if (arr_121[i_121] > arr_121[j_121])
                    {
                        a_121 = arr_121[i_121];
                        arr_121[i_121] = arr_121[j_121];
                        arr_121[j_121] = a_121;
                    }


            }
            Console.Write("Chuoi tang dan: ");
            for (int i_121 = 0; i_121 < 10; i_121++)
            {
                
                Console.Write("{0} ", arr_121[i_121]);
                
            }
            Console.WriteLine();
            Console.WriteLine("Max = {0}, Min = {1}", max_121, min_121);
            Console.ReadLine();
        }
    }
}
