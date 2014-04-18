using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStats
{
    class Program
    {
        /// <summary>
        /// This is TextStats
        /// It will take the inputted string and return the statistics... which are!
        /// Characters, Words, Vowels, Consonants, Special Characters, and (this time) Shortest word and Longest word.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TextStats("This function is called TextStats! It takes all the statistics in this very string, checks what kind of chararters they are, and prints out the amount of the values used! Isnt is just neat?!");
            Console.ReadKey();
        }
        static void TextStats(string input)
        {
            //These vars will hold number values. Some will be counters for  loops later on.
            var chars = input.Length;
            var inSplit = input.Split(' ');
            var words = inSplit.Length;
            var vowels = 0;
            var consonants = 0;
            var special = 0;

            foreach (char s in input) // this loop will check each character for specific info:
            {
                if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'u')//checking for vowels
                {
                    vowels += 1;
                }
                else if (s == '!' || s == ' ' || s == ',' || s == '.' || s == ';' || s == '?')//checking for Special Characters
                {
                    special += 1;
                }
                else //If not the top 2, then it will be a consonant +
                {
                    consonants += 1;
                }
            }
            //These vars will be placeholders for longest/shortest words in the sentence-string
            var lLength = "";
            var sLength = "bigplaceholder";
            foreach (string s in inSplit) //This loop will look at each letter, taking the longest/shortest and putting it in the previous var
            {
                if (s.Length > lLength.Length)
                {
                    lLength = s;
                }
                if (s.Length < sLength.Length)
                {
                    sLength = s;
                }
            }
            Console.WriteLine("The sentence was: ");
            Console.WriteLine(input);
            Console.WriteLine(" ");
            Console.WriteLine("Number of Characters: " + chars);
            Console.WriteLine("Number of Words: " + words);
            Console.WriteLine("Number of Vowels: " + vowels);
            Console.WriteLine("Number of Consonants: " + consonants);
            Console.WriteLine("Number of Special Characters: " + special);
            Console.WriteLine("Longest word was: " + lLength);
            Console.WriteLine("Shortest word was: " + sLength);
            //made it look pretty!
        }
    }
}
