using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            double result = (4 * Math.Pow(x, 3)) / ((Math.Pow(x, 3)) - 1);
            result = Math.Round(result, 3);

            string tempPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(tempPath, result.ToString());

            return tempPath;
        }
    }
}
