using System.Diagnostics;
using Tyuiu.DyakovMS.Sprint5.Task2.V25.Lib;
namespace Tyuiu.DyakovMS.Sprint5.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись структурированных данных в текстовый файл            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значения*");
            Console.WriteLine("*ями с клавиатуры. Заменить нечетные элементы массива на 0. Результат сохр*");
            Console.WriteLine("*ранить в файл OutPutFileTask2.csv и вывести на консоль.                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[,] matrix = new int[3, 3];
            Console.WriteLine("Введите элементы массива 3x3 (по строкам):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            string filePath = ds.SaveToFileTextData(matrix);

            Console.WriteLine("\nРезультат:");
            string[] lines = File.ReadAllLines(filePath);

            var result = ds.SaveToFileTextData(matrix);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}