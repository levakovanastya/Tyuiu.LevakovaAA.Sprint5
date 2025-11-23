using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System;
using System.Diagnostics;
using System.IO;
using Tyuiu.LevakovaAA.Sprint5.Task2.V24.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.LevakovaAA.Sprint5.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\levak\Desktop\repos\Tyuiu.LevakovaAA.Sprint5\Tyuiu.LevakovaAA.Sprint5.Task2.V24\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}