using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);

            double result = Math.Cos(Convert.ToDouble(x)) + Math.Pow(Convert.ToDouble(x), 2) - ((2 * Convert.ToDouble(x)) / 1.2);
            return Math.Round(result, 3);
            
        }
    }
}
