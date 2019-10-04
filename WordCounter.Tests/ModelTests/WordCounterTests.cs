using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void WordMatch_LooksForWordMatch_True()
        {
            Counter test = new Counter("cat", "cat");
            // string userInput = "cat";
            bool result = test.WordMatch("cat", "cat");
            Assert.AreEqual (result, true);
        }
    }
}