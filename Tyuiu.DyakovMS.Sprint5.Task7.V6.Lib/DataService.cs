using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string inputData = File.ReadAllText(path);

            StringBuilder processedData = new StringBuilder();

            foreach (char c in inputData)
            {
                if (char.IsLetter(c) && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    processedData.Append('#');
                }
                else
                {
                    processedData.Append(c);
                }
            }

            Console.WriteLine("Обработанный текст:");
            Console.WriteLine(processedData.ToString());

            string outputPath = Path.Combine(Path.GetDirectoryName(path), "OutPutDataFileTask7V6.txt");

            File.WriteAllText(outputPath, processedData.ToString());

            return $"Обработка завершена. Результат сохранен в: {outputPath}";
        }
    }
}
