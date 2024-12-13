using Tyuiu.DyakovMS.Sprint5.Task3.V3.Lib;
namespace Tyuiu.DyakovMS.Sprint5.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* потоковый метод записи данных в бинарный файл                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                            *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в би*");
            Console.WriteLine("*инарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх *");
            Console.WriteLine("* знаков после запятой.                                                   *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;
            Console.WriteLine($"Вычисление выражения y(x) = x * sqrt(x + 3) при x = {x}");
            string filePath = ds.SaveToFileTextData(x);
            double result = ds.ReadFromBinaryFile(filePath);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine($"Результат сохранен в файл: {filePath}");
            Console.ReadKey();
        }
    }
}