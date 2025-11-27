using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LevakovaAA.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string ct = text.TrimEnd('.');
            int count = ct.Split(',').Select(w => w.Trim()).Count(w => w.Length == 4);
            return count;
        }
    }
}
