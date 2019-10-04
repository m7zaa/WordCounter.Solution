using WordCounter.Models;
using System.Collections.Generic;
using System;
namespace WordCounter.Models
{
    public class Counter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }
        public int WordCount { get; set; }

        public Counter (string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
            WordCount = 0;
        }
        public bool WordMatch(string word, string sentence)
        {
            // string[] sentenceArray = sentence.Split(' ');
            if (sentence == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}