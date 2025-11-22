using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LevakovaAA.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double a = Math.Round(-0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4), 3);
            File.WriteAllText(path, Convert.ToString(a));
            return path;
        }
    }
}
