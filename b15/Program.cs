using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            DS_NhanVat dsnv = new DS_NhanVat();
            dsnv.Nhap();
            Console.WriteLine("---------------------");
            dsnv.Xuat();
            Console.WriteLine("---------------------");
            dsnv.Cau2();
            Console.WriteLine("---------------------");
            dsnv.KiemTraVaCham2();
            Console.WriteLine("---------------------");
            dsnv.Cau3();
            Console.WriteLine("---------------------");

            Console.ReadKey();

        }
    }
}
