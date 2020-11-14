using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Platform_IsAsExpected()
        {
			string platform = PlatformIdentifier.GetPlatform();
			
			Assert.AreEqual("NET Standard", platform);
        }
    }
}
