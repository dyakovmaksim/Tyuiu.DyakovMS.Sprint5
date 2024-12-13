using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string inputFilePath = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            string outputFilePath = @"C:\DataSprint5\InPutDataFileTask7V6.txt";

            string data = File.ReadAllText(inputFilePath);

            StringBuilder result = new StringBuilder();
            foreach (char ch in data)
            {
                if (Char.IsLetter(ch) && ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')))
                {
                    result.Append('#');
                }
                else
                {
                    result.Append(ch);
                }
            }

            File.WriteAllText(outputFilePath, result.ToString());

            return "Файл успешно обработан и сохранён!";
        }
    }
}
