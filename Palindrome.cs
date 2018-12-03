using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Palindrome Checker!");
            Console.WriteLine("What is the word that you want to test?");
            string word = Console.ReadLine();
            if (checkPalindrome(word))
            {
                Console.WriteLine("Your chosen word: " + word + ", is a Palindrome!");
            } else
            {
                Console.WriteLine("Your chosen word: " + word + ", is not a Palindrome");
            }
         }
        public static bool checkPalindrome(string word) {
            int x = 0; 
            int y = 0;
            for (int i = (word.Length - 1); i >= 0; i--) {
                if(word[x] == word[(word.Length - 1 - y)])
                {
                    x++;
                    y++;
                }
            }
            if (x == word.Length)
                return true;
            else
                return false;
        }
    }
}
