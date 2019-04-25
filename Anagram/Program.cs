using System;
using System.Linq;


namespace Anagram
{
    class Program
    {
      static bool IsAnagram(string word1, string word2)
      {
        char[] charArray1 = word1.ToLower().ToCharArray();
        Array.Sort(charArray1);

        char[] charArray2 = word2.ToLower().ToCharArray();
        Array.Sort(charArray2);

        return charArray1.SequenceEqual(charArray2);
      }

      static void Main()
      {
        Console.WriteLine("Enter a word");
        string word = Console.ReadLine();
        Console.WriteLine("Enter some words");
        string words = Console.ReadLine();
        string [] splitWords = words.Split(' ');

        foreach (string w in splitWords)
        {
          if (IsAnagram(word, w) == true)
          {
            Console.WriteLine("Words " + word + " and " + w + " are anagrams");
          }
          else
          {
            Console.WriteLine("Words " + word + " and " + w + " are not anagrams");
          }
        }
      }
    }
  }

        // For 1 word

        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Enter a word:");
        //     string word1 = Console.ReadLine();
        //     Console.WriteLine("Enter some words:");
        //     string words = Console.ReadLine();
        //
        //     char[] char1 = word1.ToLower().ToCharArray();
        //
        //
        //     char[] chars = words.ToLower().ToCharArray();
        //
        //     Array.Sort(char1);
        //     Array.Sort(chars);
        //
        //     string NewWord1 = new string(char1);
        //     string NewWord2 = new string(char2);
        //
        //     if (NewWord1 == NewWord2)
        //     {
        //         Console.WriteLine("Yes! Words " + word1 + " and " + word2 + " are Anagrams");
        //     }
        //     else
        //     {
        //         Console.WriteLine("No! Words " + word1 + " and " + word2 + "are not Anagrams");
        //     }
        //
        //     Console.ReadLine();
        // }
