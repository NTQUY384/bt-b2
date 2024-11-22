using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


//2287700070 Nguyen Thanh Quy
public class HocSinh
{   
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class QuanLy
{
    public List<HocSinh> danhSach;
    public QuanLy()
    {
        
        danhSach = new List<HocSinh>();
        {
            danhSach.Add(new HocSinh { Id = 123, Name = "Nguyen Thanh Quy", Age = 20 });
            danhSach.Add(new HocSinh { Id = 234, Name = "Nguyen Minh Quang", Age = 22 });
            danhSach.Add(new HocSinh { Id = 345, Name = "Le Duc Toan", Age = 18 });
            danhSach.Add(new HocSinh { Id = 456, Name = "Kieu La The Vinh", Age = 20 });
            danhSach.Add(new HocSinh { Id = 5677, Name = "An Khang Thinh Vuong", Age = 20 });
        };
    }

    //a
    public void In()
    {
        Console.WriteLine("danh sach hoc sinh");
        for(int i = 0; i < danhSach.Count; i++)
        {
            HocSinh hs = danhSach[i];
            Console.WriteLine($"id {hs.Id} ten {hs.Name} tuoi {hs.Age}");
        }
        Console.WriteLine();
    }

    //b
    public void TimTuoi()
    {
        Console.WriteLine("hs tuoi 15 - 18");
        for (int i = 0; i < danhSach.Count; i++)
        {
            HocSinh hs = danhSach[i];
            if(hs.Age >= 15 && hs.Age <= 18)
            {
                Console.WriteLine($"id {hs.Id} ten {hs.Name} tuoi {hs.Age}");
            }
            
        }
        Console.WriteLine();
    }

    //c

    public void TimA()
    {
        Console.WriteLine($"hoc sinh bd bang A");
        for (int i = 0; i < danhSach.Count; i++)
        {
            HocSinh hs = danhSach[i];
            if (hs.Name.StartsWith("A"))  // kiem tren Stack Overflow
            {
                Console.WriteLine($"id {hs.Id} ten {hs.Name} tuoi {hs.Age}");
            }

        }
        Console.WriteLine();
    }

    //d
    public void TinhTong()
    {
        int tong = danhSach.Sum(hs  => hs.Age);
        Console.WriteLine($"tong tuoi " + tong);
        Console.WriteLine();
    }

    //e
    public void Timln()
    {
        Console.WriteLine("tuoi lon nhat ");

        HocSinh lonnhat = null;

        for(int i = 0; i < danhSach.Count; i++)
        {
            HocSinh hs = danhSach[i];
            if (lonnhat == null || hs.Age > lonnhat.Age)
            {
                lonnhat = hs;
            }
        }

        if (lonnhat != null)
        {
            Console.WriteLine($"id {lonnhat.Id}, ten {lonnhat.Name}, tuoi {lonnhat.Age}");
        }
        Console.WriteLine();
    }

    //e
    public void SapXep()
    {
        Console.WriteLine("sap xep");
        for (int i = 0; i < danhSach.Count - 1; i++)
        {
            for (int j = 0; j < danhSach.Count - 1 - i; j++)
            {
                if (danhSach[j].Age > danhSach[j + 1].Age)
                {
                   
                    var temp = danhSach[j];
                    danhSach[j] = danhSach[j + 1];
                    danhSach[j + 1] = temp;
                }
            }
        
        }

        for (int i = 0; i < danhSach.Count; i++)
        {
            HocSinh hs = danhSach[i];
            Console.WriteLine($"id {hs.Id}, ten {hs.Name}, tuoi {hs.Age}");
        }

            Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        QuanLy quanLy = new QuanLy();

        quanLy.In();
        quanLy.TimTuoi();
        quanLy.TimA();
        quanLy.TinhTong();
        quanLy.Timln();
        quanLy.SapXep();

        Console.ReadLine();
    }
}