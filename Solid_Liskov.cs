using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudyTest
{
    public class Solid_LiskovTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string subStr = "nhat;;tri";
            var splits = subStr.Split(";");
            Assert.AreEqual(splits.Length, 3);
            Assert.AreEqual(splits.Length, 2);
        }

        [Test]
        public void UtilsTest()
        {

        }

    }
    // First time
    public class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            throw new NotImplementedException();
        }
        public string SaveText()
        {
            /* Code to save text into sql file */
            throw new NotImplementedException();
        }
    }
    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set}

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                objFile.SaveText();
            }
        }
    }

    // Second time
    /*
    public class SqlFile
    {
        public string LoadText()
        {
            //Code to read text from sql file
            throw new NotImplementedException();
        }
        public void SaveText()
        {
            //Code to save text into sql file
        }
    }
    public class ReadOnlySqlFile : SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            // Code to read text from sql file
            throw new NotImplementedException();
        }
        public void SaveText()
        {
            // Throw an exception when app flow tries to do save.
            throw new IOException("Can't Save");
        }
    }

    //To avoid an exception we need to modify "SqlFileManager"
    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                //Check whether the current file object is read-only or not.If yes, skip calling it's  
                // SaveText() method to skip the exception.  

                if (!(objFile is ReadOnlySqlFile))
                    objFile.SaveText();
            }
        }
    }
*/
  
}