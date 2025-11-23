using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint5.Task3.V18.Lib;
namespace Tyuiu.LevakovaAA.Sprint5.Task3.V18
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 2;

            Console.Title = "Спринт #5 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись структурированных данных в текстовый файл            *");
            Console.WriteLine("* Задание 2                                                               *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов. Заменить           *");
            Console.WriteLine("* положительные элементы массива на 1, отрицательные на 0. Результат      *");
            Console.WriteLine("* сохранить в файл OutPutFileTask2.csv и вывести на консоль.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
