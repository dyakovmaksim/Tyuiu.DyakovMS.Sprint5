using Tyuiu.DyakovMS.Sprint5.Task1.V22.Lib;
namespace Tyuiu.DyakovMS.Sprint5.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            Console.WriteLine("*Дана функция, произвести табулирование на заданном диапазоне [-5; 5] с   *");
            Console.WriteLine("*шаагом 1. Произвести проверку деления на ноль.                           *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите начальное значение диапазона:");
            int.TryParse(Console.ReadLine(), out int startValue);
            
            Console.WriteLine("Введите конечное значение диапазона:");
            int.TryParse(Console.ReadLine(), out int stopValue);
                
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(startValue, stopValue);
            string result = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"Результат сохранён в файл: {filePath}");
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}