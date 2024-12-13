using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = "OutPutFileTask1.txt";
            List<string> lines = new List<string>();

            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                try
                {
                    result = TabulateFunction(x);
                }
                catch (DivideByZeroException)
                {
                    result = 0;
                }

                lines.Add($"x = {x}, F(x) = {result:F2}");
            }

            File.WriteAllLines(filePath, lines);
            return filePath;
        }

        private double TabulateFunction(double x)
        {
            if (x == 2)
            {
                throw new DivideByZeroException();
            }

            double value = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
            return value;
        }
    }
}
