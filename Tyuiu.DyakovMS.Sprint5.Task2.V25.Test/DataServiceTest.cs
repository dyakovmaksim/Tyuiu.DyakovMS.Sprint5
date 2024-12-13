using System.Diagnostics;
using Tyuiu.DyakovMS.Sprint5.Task2.V25.Lib;

namespace Tyuiu.DyakovMS.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3]
            {
                { 4, 8, 5 },
                { 1, 4, 2 },
                { 4, 9, 9 }
            };

            string filePath = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(filePath), "Output file was not created.");
            string[] lines = File.ReadAllLines(filePath);
            Assert.AreEqual("4;8;0", lines[0]);
            Assert.AreEqual("0;4;2", lines[1]);
            Assert.AreEqual("4;0;0", lines[2]);
        }
    }
}