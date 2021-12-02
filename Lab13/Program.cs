using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("г.Морковск, ул.Душная, д.1",20,25,10);
            MultiBuilding multibuilding = new MultiBuilding("г.Капустин, ул.Тупиковая, д.666",20,40,50,60);
            building.Print();
            multibuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Lenght { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }

        public Building()
        { 
        
        
        }

        public Building (string adress, int lenght, int width, int hight)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Hight = hight;
        }
        public void Print()
        {
            Console.WriteLine("Адрес: {0}, Длина: {1}, Ширина: {2}, Высота: {3}", Adress, Lenght, Width, Hight);
        }    
    }
    sealed class MultiBuilding : Building
    { 
        public int Floor { get; set; }
        public MultiBuilding(string adress, int lenght, int width, int hight, int floor)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Hight = hight;
            Floor = floor;
        }
        public void Print()
        {
            Console.WriteLine("Адрес: {0}, Длина: {1}, Ширина: {2}, Высота: {3}, Этажей: {4}", Adress, Lenght, Width, Hight, Floor);
        }
    }
}
