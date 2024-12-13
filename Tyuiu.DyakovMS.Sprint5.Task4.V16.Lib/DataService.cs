using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double result = Math.Cos(Convert.ToDouble(strX)) + Math.Pow(Convert.ToDouble(strX), 2) - ((2 * Convert.ToDouble(strX)) / 1.2);
            return Math.Round(result, 3);
            
        }
    }
}
