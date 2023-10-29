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
            int a = 5;

            int b = 5;

            bool result = a == b;

            Console.WriteLine(result);
        }
    }
}
