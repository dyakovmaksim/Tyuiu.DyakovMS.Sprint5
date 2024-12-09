using Tyuiu.DyakovMS.Sprint5.Task1.V22.Lib;

namespace Tyuiu.DyakovMS.Sprint5.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string filePath = ds.SaveToFileTextData(startValue, stopValue);
            string[] resultLines = File.ReadAllLines(filePath);

            Assert.IsTrue(File.Exists(filePath));
            Assert.AreEqual(12, resultLines.Length);
        }
    }
}