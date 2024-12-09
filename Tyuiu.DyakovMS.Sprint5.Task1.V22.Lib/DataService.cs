using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;
                try
                {
                    double denominator = 2 - x;
                    if (denominator == 0)
                        fx = 0;
                    else
                    {
                        fx = Math.Sin(x) + (Math.Cos(x) + 1) / denominator + 2 * x;
                    }
                }
                catch
                {
                    fx = 0;
                }

                fx = Math.Round(fx, 2);
            }

            string tempPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            return tempPath;
        }
    }
}
