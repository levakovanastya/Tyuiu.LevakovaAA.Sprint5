using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LevakovaAA.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {

            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string fileContent = reader.ReadToEnd();
                string[] numbers = fileContent.Split(' ');
                int maxprime = 0;
                foreach (string number in numbers)
                {
                    string f = number.Replace('.', ',');
                    if (int.TryParse(number, out int n) && n > maxprime && IsPrime(n))
                    {
                        {
                            maxprime = n;
                        }
                        res = Convert.ToDouble(f);
                    }
                }
                return maxprime;
            }
        }



        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
