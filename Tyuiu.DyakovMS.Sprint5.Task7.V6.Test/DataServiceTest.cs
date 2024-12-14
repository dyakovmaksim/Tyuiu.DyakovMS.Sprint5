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

        }
    }
}