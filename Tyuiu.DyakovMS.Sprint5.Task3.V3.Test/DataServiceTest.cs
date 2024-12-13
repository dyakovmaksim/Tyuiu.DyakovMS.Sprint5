using Tyuiu.DyakovMS.Sprint5.Task3.V3.Lib;

namespace Tyuiu.DyakovMS.Sprint5.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string filePath = ds.SaveToFileTextData(x);
            Assert.IsTrue(File.Exists(filePath));
        }
    }
}