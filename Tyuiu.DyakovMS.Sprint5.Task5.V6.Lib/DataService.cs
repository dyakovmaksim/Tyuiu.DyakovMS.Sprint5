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

            // Открываем файл для чтения
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на отдельные элементы (числа)
                    var tokens = line.Split(new[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var token in tokens)
                    {
                        try
                        {
                            // Преобразуем каждый токен в вещественное число с учетом инвариантной культуры
                            double number = Convert.ToDouble(token, CultureInfo.InvariantCulture);
                            sum += number;  // Добавляем число в сумму
                            count++;         // Увеличиваем количество чисел
                        }
                        catch (FormatException)
                        {
                            // Если токен нельзя преобразовать в число, выводим сообщение об ошибке
                            Console.WriteLine($"Не удалось распарсить токен: {token}");
                        }
                    }
                }
            }

            // Если чисел не было найдено, выбрасываем исключение
            if (count == 0)
            {
                throw new InvalidOperationException("Не удалось найти вещественные числа в файле.");
            }

            // Вычисление среднего значения
            double average = sum / count;

            // Выводим подробности для отладки
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Количество чисел: {count}");

            // Округляем результат до 3 знаков после запятой
            return Math.Round(average, 3);
        }
    }
}
