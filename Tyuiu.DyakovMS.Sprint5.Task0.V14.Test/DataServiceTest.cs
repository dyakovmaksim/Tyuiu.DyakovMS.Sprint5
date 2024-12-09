using Tyuiu.DyakovMS.Sprint5.Task0.V14.Lib;

namespace Tyuiu.DyakovMS.Sprint5.Task0.V14.Test
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
            string result = File.ReadAllText(filePath);

            Assert.IsTrue(File.Exists(filePath));
            Assert.AreEqual("4,154", result);
        }
    }
}