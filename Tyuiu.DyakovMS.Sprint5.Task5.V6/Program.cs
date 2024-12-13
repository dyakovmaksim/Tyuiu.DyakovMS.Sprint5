using System.Diagnostics;
using Tyuiu.DyakovMS.Sprint5.Task5.V6.Lib;
namespace Tyuiu.DyakovMS.Sprint5.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение набора данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask5V6.txt (файл взять из архива со*");
            Console.WriteLine("*огласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопиро*");
            Console.WriteLine("*овать в неё файл) в котором есть набор значений. Найти среднее значение в*");
            Console.WriteLine("*всех вещественных чисел в файле. Полученный результат вывести на консоль.*");
            Console.WriteLine("*. У вещественных значений округлить до трёх знаков после запятой.        *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";
            double average = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Среднее значение вещественных чисел в файле: {average}");
            Console.ReadKey();
        }
    }
}