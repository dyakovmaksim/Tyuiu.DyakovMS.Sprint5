using Tyuiu.DyakovMS.Sprint5.Task0.V14.Lib;
namespace Tyuiu.DyakovMS.Sprint5.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в те*");
            Console.WriteLine("*екстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх*");
            Console.WriteLine("*х знаков после запятой.                                                  *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Введите значение x:");
            int.TryParse(Console.ReadLine(), out int x);

            string filePath = ds.SaveToFileTextData(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"Результат сохранён в файл: {filePath}");
            Console.WriteLine($"Результат вычисления: {result}");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}