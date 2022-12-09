using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyTest
{
    class UtilsTest
    {
        [Test]
        public void Test2()
        {
            string a = "  hello world   ";
            var trim = a.Trim();
            var rtrim = a.TrimEnd();
            var ltrim = a.TrimStart();
        }

        [Test]
        public void Test_join()
        {
            IList<string> str = new List<string>() { "nhat", "le", "minh"};

            string joins = string.Join(",", str);
        }

        [Test]
        public void TryCatchTest()
        {
            TryCatchDemo();
        }

        [Test]
        public void DemoNullTest()
        {
            var cls = new DemoNullField()
            {
                Desc = "hello class"
            };

            Assert.IsNull(cls.CreatedBy);
            Assert.IsNull(cls.CreatedDate);
        }

        [Test]
        public void IEnumableTest()
        {
            IEnumerable<DemoNullField> a = null;
            IList<DemoNullField> a1 = new List<DemoNullField> { new DemoNullField { Desc = "test 1" } };
            a = a1;
            //var ret = (DemoNullField[])a;// can't cast
            var aa = a1.ToArray();
            var ret2 = (DemoNullField[])aa;
        }

        private string TryCatchDemo()
        {
            int a = 1;
            object b = 0;
            try
            {
                b = (long)1/(int)b;
                return "hello";
            }
            catch
            {
                throw;
            }
            finally
            {
                Console.WriteLine("hello world");
            }

        }

        public class DemoNullField
        {
            public DateTime CreatedDate { get; set; }
            public int CreatedBy { get; set; }
            public string Desc { get; set; }
        }
    }
}
