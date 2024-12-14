using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string inputData = File.ReadAllText(path); // Читаем входной файл
            StringBuilder processedData = new StringBuilder();

            foreach (char c in inputData)
            {
                // Проверяем, является ли символ латинской буквой
                if (char.IsLetter(c) && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    processedData.Append('#'); // Заменяем букву на #
                }
                else
                {
                    processedData.Append(c); // Оставляем символ без изменений
                }
            }

            Console.WriteLine("Обработанный текст:");
            Console.WriteLine(processedData.ToString());

            // Генерируем путь для выходного файла
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");

            // Создаем папку, если она отсутствует
            string directory = Path.GetDirectoryName(outputPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Пишем результат в выходной файл
            File.WriteAllText(outputPath, processedData.ToString());

            return $"Обработка завершена. Результат сохранен в: {outputPath}";
        }
    }
}
