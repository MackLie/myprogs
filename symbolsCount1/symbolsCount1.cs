using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace symbolsCount1
{
    class symbolsCount1
    {
        
        static void Main(string[] args)
        {
            
            
            string realStr = "t5qr33d56q3";//исходная строка
            string symb = "536";//скрока с искомыми символами
            int count = 0;//счетчик
            Console.WriteLine("String=" + realStr);//выводим в консоль искомую строку
            foreach (Char c in symb)//посимволньно сравниваем две стоки 
            {
                foreach (Match m in Regex.Matches(realStr, c.ToString()))//если символы совпадают то увеличиваем счетчик на 1
                    count++;
                Console.WriteLine(c.ToString()+"="+count.ToString());//выводим результат для символа в консоль
                count = 0;//обнуляем счетчик
            }
            Console.ReadKey(); //тормозим программу чтобы увидеть резльтат в консоли   
        }
    }
}
