using WordCounter.Models;
using System.Collections.Generic;
using System;
using System.Linq;
namespace WordCounter.Models
{
    public class Counter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }
        public int WordCount { get; set; }

        public Counter ()
        {
            Word = "";
            Sentence = "";
            WordCount = 0;
        }
        public bool WordMatch(string word, string sentence)
        {
            if (sentence == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WordCounter(string word, string sentence)
        {
            string lowerCaseWord = word.ToLower();
            string lowerCaseSentence = sentence.ToLower();
            string[] sentenceArray = lowerCaseSentence.Split(' ');
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (sentenceArray[i] == lowerCaseWord || sentenceArray[i] + '.' == lowerCaseWord)
                {
                    this.WordCount +=1;
                }
                else
                {
                    this.WordCount +=0;
                }
            }
        }

    }
}