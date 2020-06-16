using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyrcleConsole
{
    public class Cyrcle
    {
        static List<int> _list;
        public Cyrcle(List<int> list)
        {
            _list = list;
        }

        public static int getNext(int i)
        {
            return _list[i];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Cyrcle c = new Cyrcle(list);
            int i = 0;
            Console.WriteLine("start count of try 5");


            int TRY = 5;

            Console.WriteLine("****************************");
            int flag = 0;
            while (flag == 0)
            {

                while (TRY >= 1)
                {
                    if (i == list.Count)
                        i = 0;
                    Console.WriteLine(Cyrcle.getNext(i).ToString());
                    i++;
                    TRY--;
                }
                try
                {
                    Console.WriteLine("Enter try count");
                    TRY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("****************************");
                }
                catch
                {
                    Console.WriteLine("Invalid input!!!");
                }
            }
        }
    }
}
