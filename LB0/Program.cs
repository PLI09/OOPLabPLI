using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k; //Создаем переменную, которая будет в себе хранить квадрат числа
            for (int i = 11; i <= 19; i++) 
            {
                k = Convert.ToInt32(Math.Pow(i, 2)); // Выполняем возведение в степень
                Console.WriteLine($"Квадрат числа {i} равен {k}");
            }
            Console.ReadLine();
        }
    }
}
