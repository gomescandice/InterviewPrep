using System;
using System.Collections.Generic;
namespace InterviewStudy
{
    class Interview
    {
        static void Main(string[] args)
        {
            // REVERSE STRING CHECK
            //    Console.WriteLine("Reverse Strings - App");
            //    Console.Write("Text1: ");
            //    string inputText1 = Console.ReadLine();
            //    Console.Write("Text2: ");
            //    string inputText2 = Console.ReadLine();
            //    ReverseString r = new ReverseString();
            //    bool reverseResult = r.Validate(inputText1, inputText2);
            //    string reverserText = reverseResult ? "Strings are reverse of each other." : "Strings are not equal in reverse.";
            //    Console.WriteLine(reverserText);

            // PALINDROME
            //    Console.WriteLine("Palindrome - App");
            //    Console.Write("Text: ");
            //    string inputText3 = Console.ReadLine();
            //    Palindrome p = new Palindrome();
            //    bool palindromeResult = p.Validate(inputText3);
            //    string palindromeText = palindromeResult ? "String is a palindrome." : "String is not a palindrome.";
            //    Console.WriteLine(palindromeText);

            // FIRST NON REPEATED CHARACTER
            //    Console.WriteLine("First non repeating character - App");
            //    Console.Write("Text: ");
            //    string inputText4 = Console.ReadLine();
            //    NonRepeatedChar c = new NonRepeatedChar();
            //    string nonRepeatingResult = c.FindFirstChar(inputText4);
            //    string nonRepeatingText = "Result:" + nonRepeatingResult;
            //    Console.WriteLine(nonRepeatingText);

            // ANAGRAM
            //    Console.WriteLine("Anagram - App");
            //    Console.Write("Text1: ");
            //    string inputText5 = Console.ReadLine();
            //    Console.Write("Text2: ");
            //    string inputText6 = Console.ReadLine();
            //    Anagram a = new Anagram();
            //    bool anagramResult = a.Validate(inputText5, inputText6);
            //    string anagramText = anagramResult ? "Strings are anagrams." : "String are not anagrams." ;
            //    Console.WriteLine(anagramText);

            // ADD ONE
            //    Console.WriteLine("First non repeating character - App");
            //    Console.Write("Text: ");
            //    int inputText7 = Convert.ToInt32(Console.ReadLine());
            //    AddOne ao = new AddOne();
            //    int nonRepeatingResult = ao.AddOneToArray(inputText7);
            //    string nonRepeatingText = "Result: " + nonRepeatingResult.ToString();
            //    Console.WriteLine(nonRepeatingText);

            // MAX
            //   Console.WriteLine("Max in array - App");
            //   int[] inputText8 = { 4, 3, 7, 8, 2, 1, 7, 0, 2, 43, 22, 788, 999 };
            //   FindMax m = new FindMax();
            //   int maxResult = m.Find(inputText8);
            //   string maxText = "Result: " + maxResult.ToString();
            //   Console.WriteLine(maxText);

            // QUICK SORT
            //  Console.WriteLine("Quick sort - App");
            //  int[] inputText9 = { 29,4, 3, 7, 8, 1, 7, 0, 2, 43, 22, 788, 999 };
            //  QuickSort q = new QuickSort();
            //  q.Sort(inputText9, 0, inputText9.Length-1);
            //  string sortResult = q.ArraytoString(inputText9);
            //  string sortext = "Result: " + sortResult;
            //  Console.WriteLine(sortext);

            // LINKED LIST SEARCH
            //  LinkedList l = new LinkedList();
            //  l.Push(3);
            //  l.Push(10);
            //  l.Push(4);
            //  l.Push(5);
            //  l.Push(7);
            //  l.Push(22);
            //  l.Push(15);
            //  bool llResult =  l.Search(l.head,5);
            //  string lltext = "Result: " + ((llResult) ? "Found" : "Not found");
            //  Console.WriteLine(lltext);

            // MERGE SORT
            Console.WriteLine("Merge sort - App");
              int[] inputText9 = { 29,4, 3, 7, 8, 1, 7, 0, 2, 43, 22, 788, 999 };
              MergeSort q = new MergeSort();
              q.Sort(inputText9, 0, inputText9.Length-1);
              string sortResult = q.ArraytoString(inputText9);
              string sortext = "Result: " + sortResult;
              Console.WriteLine(sortext);

        }
    }
}
