using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            var lines = File.ReadLines(path);
            var numbers = new List<double>();

            foreach (var line in lines)
            {
                var tokens = line.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var token in tokens)
                {
                    if (double.TryParse(token, out double number))
                    {
                        numbers.Add(number);
                    }
                }
            }

            double average = numbers.Average();
            return Math.Round(average, 3);
        }
    }
}
