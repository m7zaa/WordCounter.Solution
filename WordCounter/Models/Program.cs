using WordCounter.Models;
using System.Collections.Generic;
using System;
namespace WordCounter.Models
{
    class Program
    {
        static void Main()
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("Hello! Let's play a game. I'm going to have you input a sentence and then seperately input a word. I will tell you how many times that word is in the sentence");
            Console.WriteLine("Input a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Input a word:");
            string word = Console.ReadLine();
            Counter count = new Counter();
            count.WordCounter(word, sentence);
            Console.WriteLine(count.WordCount);
            Console.WriteLine("Would you like to play again? Y/N");
            string repeatYN = Console.ReadLine();
            if (repeatYN == "y" || repeatYN == "Y")
            {
                Start();                
            }
            else
            {
                Console.WriteLine("Thanks for playing! Have a great day!");
            }
        }
    }
}