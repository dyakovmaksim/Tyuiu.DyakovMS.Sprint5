using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyakovMS.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] line = new string[cols];
                    for (int j = 0; j < cols; j++)
                    {
                        line[j] = matrix[i, j].ToString();
                    }
                    writer.WriteLine(string.Join(";", line));
                }
            }

            return filePath;
        }
    }
}
