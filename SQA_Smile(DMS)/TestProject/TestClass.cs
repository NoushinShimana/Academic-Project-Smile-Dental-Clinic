using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WindowsFormsApplication1;



namespace TestProject
{
      [TestFixture]
   public  class TestClass
   {
       Login_Page log = new Login_Page();

 [Test]
       public void DatabaseSaveTest()
       {
           bool t = log.SaveToDB("shimana", "282");
           Assert.IsTrue(t);
       }
    }
}
