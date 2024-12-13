using Tyuiu.DyakovMS.Sprint5.Task6.V23.Lib;

namespace Tyuiu.DyakovMS.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();
            string filePath = @"C:\\DataSprint5\\InPutDataFileTask6V23.txt";

            var res = ds.LoadFromDataFile(filePath);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}