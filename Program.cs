using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Массив размера N --------------");
            Console.Write("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            //массив типа double с именем array и размером N
            double[] array = new double[N]; 

            Console.WriteLine("Введите элементы массива через enter:");
            for (int i = 0; i < N; i++)
            {
                array[i] = double.Parse(Console.ReadLine()); // Читает элементы массива
            }

            double maxAbs = array.Max(x => Math.Abs(x)); // Находит максимальный по модулю элемент

            // Нормирует массив
            for (int i = 0; i < N; i++)
            {
                array[i] /= maxAbs;//делит каждый элемент на максимальный по модулю
            }

            // Выводит нормированные элементы
            Console.WriteLine("Нормированный массив: " + string.Join(", ", array));
            Console.ReadLine();

            Console.WriteLine("--------------целочисленный массив из 10-ти элементов--------------");
            int[] array2 = new int[10] { 15, 25, 35, 45, 55, 65, 75, 85, 95, 105 };
            Console.WriteLine(string.Join(", ", array2));

            Console.Write("Введите целое число для замены: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int maxIndex = Array.IndexOf(array2, array2.Max()); // Находиm индекс максимального элемента
            array2[maxIndex] = number; // Заменяеm его

            Console.WriteLine("Измененный массив: " + string.Join(", ", array2));
            Console.ReadLine();
        }
    }
}
