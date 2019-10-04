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
            Counter test = new Counter();
            // string userInput = "cat";
            bool result = test.WordMatch("cat", "cat");
            Assert.AreEqual (result, true);
        }

        [TestMethod]
        public void WordCounter_LooksForWordMatch_1()
        {
            Counter test = new Counter();
            test.WordCounter("cat", "The cat");
            Assert.AreEqual(1, test.WordCount);
        }

        [TestMethod]
        public void WordCounter_LooksForSpecificWordMatch_1()
        {
            Counter test = new Counter();
            test.WordCounter("cat", "The cathedral has a cat that lives inside.");
            Assert.AreEqual(1, test.WordCount);
        }
    }
}