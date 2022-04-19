using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinh
{

    class HinhHoc
    {
        public virtual void nhanBiet()
        {
            Console.WriteLine("Hinh la tap hop cac duong thang tao thanh 1 khong gian khep kin");
        }
    }

    class HinhTron : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Day la hinh tron: \n");
            Console.WriteLine("Hinh tron la cac điem nam tren duong tron va nam trong duong tron do.");
        }
    }

    class HinhVuong : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Day la hinh vuong: \n");
            Console.WriteLine("hinh vuong la hinh tu giac đeu, tuc co 4 canh bang nhau va 4 goc bang nhau");
        }
    }

    class HinhTamGiac : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Day la hinh tam giac: \n");
            Console.WriteLine("Tam giac la da giac co so canh it nhat (3 canh), co ba dinh la ba diem khong thang hang va ba canh la ba doan thang noi cac đinh voi nhau.");
        }
    }

    class HinhBinhHanh : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Day la hinh Binh Hanh: \n");
            Console.WriteLine("Hinh binh hanh la mot hinh tu giac đuoc tao thanh khi hai cap duong thang song song cat nhau");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            HinhHoc htron = new HinhTron();
            HinhHoc hvuong = new HinhVuong();
            HinhHoc htamgiac = new HinhTamGiac();
            HinhHoc hBinhhanh = new HinhBinhHanh();
            htron.nhanBiet();
            hvuong.nhanBiet();
            htamgiac.nhanBiet();
            hBinhhanh.nhanBiet();
            Console.ReadKey();
        }
    }
}