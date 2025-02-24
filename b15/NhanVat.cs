using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b15
{
    internal  class NhanVat
    {
        public int MaNV {  get; set; }
        public double PointX { get; set; }
        public double PointY { get; set; }
        public  double Width { get; set; }
        public  double Height { get; set; }
        public void Nhap() {
            Console.WriteLine("Mã NV: ");
            MaNV = int.Parse(Console.ReadLine());
            Console.WriteLine("PointX: ");
            PointX = double.Parse(Console.ReadLine());
            Console.WriteLine("PointY: ");
            PointY = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {

            Console.Write("MaNV: " + MaNV +
                ", PointX: " + PointX +
                ", Width: " + Width +
                ", Height: " + Height);

        }
        public bool KiemTraVaCham(NhanVat v)
        {
            return this.PointX < v.PointX + v.Width &&
                   this.PointX + this.Width > v.PointX &&
                   this.PointY < v.PointY + v.Height &&
                   this.PointY + this.Height > v.PointY;
        }
        //public void checkCollision(x1, y1, w1, h1, x2, y2, w2, h2)
        //{
        //    return x1 < x2 + w2 &&
        //           x1 + w1 > x2 &&
        //           y1 < y2 + h2 &&
        //           y1 + h1 > y2;
        //}
    }
}
