using Tyuiu.DyakovMS.Sprint5.Task6.V23.Lib;
namespace Tyuiu.DyakovMS.Sprint5.Task6.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask6V23.txt (файл взять из архива с*");
            Console.WriteLine("*согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопир*");
            Console.WriteLine("*ровать в неё файл) в котором есть набор символьных данных.Найти количеств*");
            Console.WriteLine("*во знаков тире в заданной строке.                                        *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string tempDirectory = Path.GetTempPath();

            string filePath = Path.Combine(tempDirectory, @"C:\\DataSprint5\\InPutDataFileTask6V23.txt");

            string fileDirectory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(fileDirectory))
            {
                Directory.CreateDirectory(fileDirectory);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Это строка с - тире. - Еще одно тире. \nТретья строка с - тире.");
            }

            DataService ds = new DataService();
            int dashCount = ds.LoadFromDataFile(filePath);

            Console.WriteLine($"Количество знаков тире в файле: {dashCount}");
        }
    }
}