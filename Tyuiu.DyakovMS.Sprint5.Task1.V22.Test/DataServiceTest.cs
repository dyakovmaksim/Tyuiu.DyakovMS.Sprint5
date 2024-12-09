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
            Assert.AreEqual("x\tF(x)", resultLines[0]);

            string[] expectedResults = new[]
           {
                "-8.86", "-7.19", "-6.14", "-4.76", "-2.33", "1.00",
                "4.38", "0.00", "6.13", "7.07", "8.61"
            };

            for (int i = 1; i <= 11; i++) // От -5 до 5
            {
                string[] parts = resultLines[i].Split('\t');
                Assert.AreEqual(expectedResults[i - 1], parts[1]);
            }
        }
    }
}