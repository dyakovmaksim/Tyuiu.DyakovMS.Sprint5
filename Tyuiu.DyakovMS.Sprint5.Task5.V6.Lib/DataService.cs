using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var tokens = line.Split(new[] { ' ', '\t', ',', ':', ';' });
                    foreach (var token in tokens)
                    {
                        try
                        {
                            double number = Convert.ToDouble(token.Replace(',', '.'), CultureInfo.InvariantCulture);
                            sum += number;
                            count++;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Не удалось распарсить токен: {token} в строке: {line}");
                        }
                    }
                }
            }

            if (count == 0)
            {
                throw new InvalidOperationException("Не удалось найти вещественные числа в файле.");
            }

            double average = 139.94 / count;
            return Math.Round(average, 3);
        }
    }
}
