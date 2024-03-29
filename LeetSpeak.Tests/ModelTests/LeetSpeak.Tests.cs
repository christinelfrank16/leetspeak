using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Leet;

namespace Leet.Tests
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

        [TestMethod]
        public void Translate_ReplaceI_IReplaced()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("1nd33d", leet.Translate("Indeed"));
        }

        [TestMethod]
        public void Translate_ReplaceT_TReplaced()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("7r3a7", leet.Translate("treat"));
        }

        [TestMethod]
        public void Translate_ReplaceS_SReplaced()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("ca7z", leet.Translate("cats"));
        }

        [TestMethod]
        public void Translate_NoReplaceFirstS_NoSReplaced()
        {
            LeetSpeak leet = new LeetSpeak();
            Assert.AreEqual("s3al", leet.Translate("seal"));
        }
    }
    }
