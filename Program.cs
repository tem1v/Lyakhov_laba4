using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ёмкость массива:");
            int capacity = int.Parse(Console.ReadLine());
            Vector array = new Vector(capacity);
            array.Fill(1, 5);
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            Console.WriteLine();

            array.Add(6);
            Console.WriteLine("Добавление 6:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            Console.WriteLine();

            array.Delete();
            Console.WriteLine("Удаление последнего элемента:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            Console.WriteLine();

            array.Insert(2, 10);
            Console.WriteLine("Вставка 10 в индекс 2:");
            for (int i = 0; i < array.Count(); i++)
            {
                Console.Write(array.GetByIndex(i) + " ");
            }
            Console.WriteLine();

            int[] max = array.Max();
            Console.WriteLine($"Максимальное число:{ max[1]} с индексом {max[0]}");
            Console.WriteLine($"Количество элементов в массиве: {array.Count()}");
            Console.ReadLine();
        }
    }
}
