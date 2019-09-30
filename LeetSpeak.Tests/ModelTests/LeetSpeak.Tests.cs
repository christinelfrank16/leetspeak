using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void Translate_IgnoreNumbers_True()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("h3ll0", leet.Translate("h3ll0"));
        }
    }
}