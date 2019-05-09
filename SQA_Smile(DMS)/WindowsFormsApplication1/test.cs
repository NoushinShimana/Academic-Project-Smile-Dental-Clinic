using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WindowsFormsApplication1
{
    [TestFixture]
    class test
    {
        public class TestClass
        {
            Doc_info DBsave = new Doc_info();
            Login_Page log = new Login_Page();

            [Test]
            public void DatabaseSaveTest()
            {
                Boolean t = DBsave.SaveToDB("1", "Mohona", "Children", "9am-3pm");
                Assert.IsTrue(t);
            }

            [Test]
            public void null_checkup()
            { //  int? sh= Convert.ToInt32("shimana");
                Assert.Throws<ArgumentNullException>(() => log.null_check("shimana", null));
                Assert.AreEqual("Please provide UserName and Password", Assert.Throws<ArgumentNullException>(() => log.null_check("shimana", null)).ParamName);
            }

            [Test]
            public void AreEqual()
            {
                bool h = log.AreEq("shimana", "282");
                // Assert.AreEq("shimana", "282");
                Assert.IsTrue(h);

            }


            [Test]
            public void AreNotEqual()
            {
                bool l = log.AreEq("shimana", "282");
                // Assert.AreEq("shimana", "282");
                Assert.IsTrue(l);

            }
            [Test]
            public void AreGreater()
            {
                bool m = log.AreGrtr("noushinshi","2822822");
                // Assert.AreEq("shimana", "282");
                Assert.IsTrue(m);

            }





        }
    }
}
