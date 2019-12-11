using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPDockerTest;
using Lib1;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myAlbum = new Album(new Artist("BRMC", 3), "Specter at the Feast", 2013);

            Assert.AreEqual(myAlbum.Name, "Specter at the Feast");
        }
    }
}
