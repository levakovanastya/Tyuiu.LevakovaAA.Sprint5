using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LevakovaAA.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double x = Convert.ToDouble(strX);
            double res = Math.Round(1/Math.Sin(x) + Math.Pow(x, 2), 3);
            return res;
        }
    }
}
