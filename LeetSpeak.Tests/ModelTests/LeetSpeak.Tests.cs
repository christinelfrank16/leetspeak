using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void Translate_IgnoreNumbers_SameString()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("h3ll0", leet.Translate("h3ll0"));
        }

        [TestMethod]
        public void Translate_ReplaceE_EReplaced()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("h3ll0", leet.Translate("hell0"));
        }

        [TestMethod]
        public void Translate_ReplaceO_OReplaced()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("h3ll0", leet.Translate("hello"));
        }
    }
}