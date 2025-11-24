using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint5.Task4.V9.Lib;
using System;
using System.IO;
namespace Tyuiu.LevakovaAA.Sprint5.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string temppath = Path.GetTempPath();
            string path = Path.Combine(temppath, "InPutDataFileTask4V9.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
