using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text.RegularExpressions;
namespace Tyuiu.LevakovaAA.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V2.txt");
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string text = File.ReadAllText(path);
            string res = Regex.Replace(text, @"\d", "#");
            return res;
        }
    }
}
