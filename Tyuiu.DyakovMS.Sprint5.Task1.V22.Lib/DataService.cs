using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            List<string> results = new List<string>();

            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                try
                {
                    result = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                }
                catch (DivideByZeroException)
                {
                    result = 0; // Обработка деления на ноль
                }

                if (double.IsInfinity(result))
                {
                    result = 0; // Если значение бесконечно, устанавливаем 0
                }

                results.Add(Math.Round(result, 2).ToString());
            }

            File.WriteAllLines(filePath, results);
            return filePath;
        }
    }
}
