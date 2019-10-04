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
            CounterClass test = new CounterClass();
            string userInput = "cat";
            Assert.AreEqual (userInput, test.Word);
        }
    }
}