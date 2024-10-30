using System.Diagnostics;

namespace BaiTap
{
    internal class session04
    {
        ///<summary>
        ///giai va bien luan phuong trinh bac 1: ax + b = 0
        ///</summary>
        static void session04_ex01()
        {
            Console.Write("nhap he so a:"); int a = int.Parse(Console.ReadLine());
            Console.Write("nhap he so b:"); int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("x tuy y");
                else
                    Console.WriteLine("vo ly");
            if (b == 0)
                Console.WriteLine("x =0");
            else
                Console.WriteLine("X = " + (-b / (float)a));
        }

        static void session04_ex05()
        {
            Console.Write("nhap x"); int x = int.Parse(Console.ReadLine());
            Console.Write("nhap y"); int y = int.Parse(Console.ReadLine());
            if (x < 0 && y > 0)
            { Console.WriteLine("toa do thuoc phan tu thu 1"); }
            else if (x > 0 && y > 0)
            { Console.WriteLine("toa do thuoc phan tu thu 2"); }
            else if (x > 0 && y < 0)
            { Console.WriteLine("toa do thuoc phan tu thu 3"); }
            else if (x < 0 && y < 0)
            { Console.WriteLine("toa do thuoc phan tu thu 4"); }
        }
    }
}
