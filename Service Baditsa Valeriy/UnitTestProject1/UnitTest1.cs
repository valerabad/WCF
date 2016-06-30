using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestService
    {
        Service.DataTransferService service = new Service.DataTransferService();

        [TestMethod]
        public void TestfFctorial()
        {
            int i = 4;
           
            int actual = service.CalcFactorial(i);
            int expected = 24;
            Assert.AreEqual(expected, actual);        
        }

        [TestMethod]
        public void TestfReverseString()
        {           
            string testStr = "abcd123";
            string actual = service.ReversString(testStr);
            string expected = "321dcba";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestfGetPlayer()
        {
            service.listPlayers.Add(new Player(0,"testName","testLastName",123));            
            string actual = service.GetPlayer(0).FirstName;
            string expected = "testName";
            Assert.AreSame(expected, actual);           
        }

        [TestMethod]
        public void TestfSetPlayer()
        {
            service.SetPlayer(new Player(0, "testName", "testLastName", 123));           
            Assert.IsTrue(service.listPlayers.Exists(x => x.Level == 123));
        }
    }
}
