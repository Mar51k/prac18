using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вариант 14
            Console.WriteLine("Укажите характеристики автомобиля: марка, стоимость(в тысячах), расход топлива на 100км, надёжность(число лет безотказной работы), комфортность(5,4,3)");
            Console.WriteLine("Укажите марку автомобиля: ");
            string mark = Console.ReadLine();
            Console.WriteLine("Укажите стоимость автомобиля в тысячах: ");
            double costs = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите расход автомобиля на 100км: ");
            double expenses = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите надёжность автомобиля: ");
            int safety = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите комфортность автомобиля (5,4,3): ");
            int comfort = int.Parse(Console.ReadLine());
            if (comfort > 5 || comfort < 3)
            {
                while (comfort < 3  || comfort > 5)
                {
                    Console.WriteLine("Такого значения нет в системе, попробуйте снова!");
                    Console.WriteLine("Укажите комфортность автомобиля (5,4,3): ");
                    comfort = int.Parse(Console.ReadLine());
                }
                
            }


        }
    }
}
