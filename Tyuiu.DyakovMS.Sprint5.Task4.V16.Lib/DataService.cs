using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            string fileContent = File.ReadAllText(path).Trim();
            if (!double.TryParse(fileContent, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
            {
                throw new FormatException("Содержимое файла не является числом.");
            }

            return value;
        }
        public double CalculateFormula(double x)
        {
            double result = Math.Cos(x) + Math.Pow(x, 2) - ((2 * x) / 1.2);
            return Math.Round(result, 3);
        }
    }
}
