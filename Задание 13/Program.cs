using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите данные:  ");
            Console.Write("Адрес:  ");
            string Add1 = Console.ReadLine();
            Console.Write("Длину дома:  ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ширину дома:  ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высоту дома:  ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Этажность:  ");
            int lev = Convert.ToInt32(Console.ReadLine());
            Building Building1 = new Building(Add1, l, w, h);
            Building1.Print(Add1, l, w, h);
            MultiBuilding MultiBuilding1 = new MultiBuilding(Add1, l, w, h,lev);
            MultiBuilding1.Print(Add1, l, w, h, lev);
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public virtual void Print(string Address, double Length, double Width, double Height)
        {
            Console.WriteLine("Адрес дома :{0}, Длина :{1}, Ширина :{2}, Высота : {3}", Address, Length, Width, Height);
        }

    }
    class MultiBuilding : Building
    {
        public int Level { get; set; }
        public MultiBuilding (string Address, double Length, double Width, double Height, int level)
            :base(Address, Length, Width, Height)
        {
            Level = level;
        }
        public  void Print(string Address, double Length, double Width, double Height, int Level)
        {
            Console.WriteLine("Адрес дома :{0}, Длина :{1}, Ширина :{2}, Высота : {3}, Этажность :{4}", Address, Length, Width, Height, Level);
        }
    }
}
 