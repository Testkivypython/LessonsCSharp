using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
/*
 * == - Равно
 * != - Не равно
 * > - больше
 * < - меньше
 * >= - больше или равно
 * <= - меньше или равно
 */

namespace LessonsSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHighTempureProcessor = false; 
            bool isHighTempureVideo = false;

            while (true){
                double tempureProcessor, tempureVideo;
                string a, b;

                Console.WriteLine("Введите температуру процессора (Введите exit для выхода из приложения)");
                a = Console.ReadLine();

                if(a == "exit")
                {
                    break;
                }
                else
                {
                    double.TryParse(a, out tempureProcessor);
                }


                if (tempureProcessor > 105) {
                    isHighTempureProcessor = true;
                }

                Console.WriteLine("Введите температуру видеоядра");
                b = Console.ReadLine();

                if (b == "exit")
                {
                    break;
                }
                else
                {
                    double.TryParse(a, out tempureVideo);
                }

                if(tempureVideo > 100) {
                    isHighTempureVideo = true;
                }

                if (isHighTempureProcessor || isHighTempureVideo)
                {
                    Console.WriteLine("Угроза взрыва компьютера!!!");
                    break;
                }
            }
        }
    }
}
