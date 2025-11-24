using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint5.Task4.V9.Lib;
namespace Tyuiu.LevakovaAA.Sprint5.Task4.V9
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение данных из текстового файла                                       *");
            Console.WriteLine("* Задание 4                                                               *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Дан файл в котором есть вещественное значение. Прочитать значение из    *");
            Console.WriteLine("* файла и подставить вместо Х в формуле.Вычислить значение по формуле     *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask4V9.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
