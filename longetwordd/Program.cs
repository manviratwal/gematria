using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longetwordd 
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is : ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        private bool MyFunctionA(string v)
        {
            throw new NotImplementedException();
        }
        
        public MyFunctionA(string input)
        {
            //Write a C# program to find the longes word in a string.
            string[] words = input.Split(' ');
            int wordarrayLength = words.Length;

            foreach (var wod in words)
            {
                //TODO
            }
            // loop post condition: we now jave array wordsLength which contains the lengths of each word

            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                // TODO :Use an IF Statementr to make sure thet variable longestWord is always set to the Longest Word in the input string
            }
            
        }

        public Program()
        {
        }
    }
}
