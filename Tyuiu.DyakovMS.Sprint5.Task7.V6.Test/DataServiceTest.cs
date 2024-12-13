using Tyuiu.DyakovMS.Sprint5.Task7.V6.Lib;

namespace Tyuiu.DyakovMS.Sprint5.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            DataService ds = new DataService();
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            string result = ds.LoadDataAndSave(inputPath);

            Assert.Contains("Обработка завершена", result);
            Assert.True(File.Exists(@"C:\DataSprint5\OutPutDataFileTask7V6.txt"));

        }
    }
}