using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint5.Task0.V3.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint5.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
