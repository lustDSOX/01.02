using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            while (true)
            {
                WriteArray();
                WriteLine("\nДобавить в массив значение? (y)");
                switch (ReadLine())
                {
                    case ("y"):
                        list.Add(AddArray());
                        break;
                    default:
                        Clear();
                        break;
                }
            }
        }
        static void WriteArray()
        {
            Clear();
            int i = 0;
            foreach (int item in list)
            {
                WriteLine("Индекс - {0,4}    Значение - {1,10}",i,item);
                i++;
            }
            WriteLine("\n Число элементов - {0,3}",list.Count());
            WriteLine(string.Concat(Enumerable.Repeat("___", 5)));
        }

        static int AddArray()
        {
            int i;
            while (true)
            {
                Clear();
                WriteLine("Введите новый элемент");
                try
                {
                    i = Convert.ToInt32(ReadLine());
                    break;
                }
                catch
                {
                    Clear();
                }
            }

            return i;
        }
    }
}
