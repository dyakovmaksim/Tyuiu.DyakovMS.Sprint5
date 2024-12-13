using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int dashCount = 0;
            try
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    dashCount += line.Split('-').Length - 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
            }
            return dashCount;
        }
    }
}
