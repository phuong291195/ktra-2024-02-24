using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b15
{
    internal class DS_NhanVat
    {
        List<NhanVat> list;
        public DS_NhanVat()
        {
            list = new List<NhanVat>();
        }
        public void Nhap()
        {
            Console.WriteLine("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1. Rya 2. Armor Sword Man 3. Banshee 4. Bat Man 5. Bomberhead");
                int luachon = int.Parse(Console.ReadLine());
                if (luachon == 1)
                {
                    NhanVat newnv = new Rya();
                    newnv.Nhap();
                    list.Add(newnv);
                }else if (luachon == 2)
                {
                    NhanVat newnv = new ArmorSwordMan();
                    newnv.Nhap();
                    list.Add(newnv);
                }
                else if (luachon == 3)
                {
                    NhanVat newnv = new Banshee();
                    newnv.Nhap();
                    list.Add(newnv);
                }
                else if (luachon == 4)
                {
                    NhanVat newnv = new BatMan();
                    newnv.Nhap();
                    list.Add(newnv);
                }
                else if (luachon == 5)
                {
                    NhanVat newnv = new Bomberhead();
                    newnv.Nhap();
                    list.Add(newnv);
                }
            }
        }
        public void Xuat()
        {
            foreach (NhanVat v in list)
            {

                Console.WriteLine(v.GetType().ToString());
                v.Xuat();
                Console.WriteLine();
            }
        }
        public void KiemTraVaCham()
        {
            Console.WriteLine("Chọn vị trí 1 nhân vật:");
            int index = int.Parse(Console.ReadLine());
            index -= 1;
            int stt = 0;
            bool KiemTraVaCham = false;
            foreach (NhanVat v in list)
            {
                if (index != stt)
                {
                    if (list[index].KiemTraVaCham(v))
                    {
                        KiemTraVaCham = true;
                        
                    }
                }
                stt++;


            }
            if (KiemTraVaCham)
            {
                Console.WriteLine("Có Va Chạm!!!");
            }
            else
            {
                Console.WriteLine("Không Va Chạm!!!");
            }
            //if (P.x≥R.x) and (P.x≤R.x+R.width) and (P.y≥R.y) and (P.y≤R.y+R.height) 
            //if (A.x<B.x+B.width) and (A.x+A.width>B.x) and (A.y<B.y+B.height) and (A.y+A.height>B.y) then c


        }
        public void KiemTraVaCham2()
        {
            Console.WriteLine("Chọn vị trí 1 nhân vật:");
            int index = int.Parse(Console.ReadLine());
            index -= 1;
            int stt = 0;
            int counterVaCham = 0;
            foreach(NhanVat v in list)
            {
                if (index != stt)
                {
                    if (list[index].KiemTraVaCham(v))
                    {
                        Console.WriteLine(v.GetType().ToString());
                        v.Xuat();
                        Console.WriteLine("Đang Va Chạm!!!");
                        counterVaCham++;
                    }
                }
                stt++;
            }
            if (counterVaCham == 0)
            {
                Console.WriteLine("Không có va chạm!!!");
            }
            //if (P.x≥R.x) and (P.x≤R.x+R.width) and (P.y≥R.y) and (P.y≤R.y+R.height) 
            //if (A.x<B.x+B.width) and (A.x+A.width>B.x) and (A.y<B.y+B.height) and (A.y+A.height>B.y) then c

            
        }
        public void KiemTraVaCham3()
        {
            Console.WriteLine("Chọn vị trí 1 nhân vật:");
            int index = int.Parse(Console.ReadLine());
            index -= 1;
            int stt = 0;
            string LoaiNVVaCham = "";
            int SoNVVaCham = 0;
            foreach (NhanVat v in list)
            {
                if (index != stt)
                {
                    if (list[index].GetType().ToString() != v.GetType().ToString()
                        && list[index].KiemTraVaCham(v) 
                        && LoaiNVVaCham =="")
                    {
                        LoaiNVVaCham  = v.GetType().ToString();
                        SoNVVaCham = 1;
                    }
                    else if (list[index].GetType().ToString() != v.GetType().ToString()
                        && list[index].KiemTraVaCham(v) 
                        && LoaiNVVaCham == v.GetType().ToString())
                    {
                        SoNVVaCham++;
                    }
                }
                stt++;
            }

            if (SoNVVaCham >0 )
            {
                Console.WriteLine(LoaiNVVaCham+": ("+ SoNVVaCham+ " NV)");
            }
            else
            {
                int TongSoNVCungLoai = 0;
                foreach (NhanVat v in list)
                {
                    if(list[index].GetType().ToString() == v.GetType().ToString())
                    {
                        TongSoNVCungLoai++;
                    }
                }
                Console.WriteLine(list[index].GetType().ToString() + ": (" + (TongSoNVCungLoai-1) + " NV)");
            }
            //if (P.x≥R.x) and (P.x≤R.x+R.width) and (P.y≥R.y) and (P.y≤R.y+R.height) 
            //if (A.x<B.x+B.width) and (A.x+A.width>B.x) and (A.y<B.y+B.height) and (A.y+A.height>B.y) then c


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
