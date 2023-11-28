using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint5.TaskReview.V21.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint5.TaskReview.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadDataAndSaveValid()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";  
            FileInfo fileInfo = new FileInfo(path);  
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
    }
}
