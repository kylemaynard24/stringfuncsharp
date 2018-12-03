using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What word would you like to reverse?");
            string wordToReverse = Console.ReadLine();
            string reversedWord = rev(wordToReverse);
            Console.WriteLine("This is your word reverse: " + reversedWord);
            Console.WriteLine("Does it look like a palindrome?"); //next function
        }

        public static string rev(string word)
        {
            string reversed = " ";
            int size = word.Length;
            char[] rev = new char[size];
            int x = 0;
            for(int i = word.Length - 1; i >= 0; i--)
            {
                rev[x] = word[i];
                x++;
            }
            for(int i = 0; i < word.Length; i++)
            {
                reversed += rev[i];
            }
            return reversed;
        }
    }
}
