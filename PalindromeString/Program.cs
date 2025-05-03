using PalindromeString;
using System;

Console.WriteLine("Hello, World!");

string test1 = "qwerty";
string test2 = "qweryt";
string test3 = "qwerab";

Action<string, string> testFunc = (string s1, string s2) =>
{
    bool testResult = PalindromeChecker.CheckIfPalindrome(s1, s2);

    Console.WriteLine("Strings " + s1 + " and " + s2
        + (testResult ? " are palindrome" : " aren't palindrome"));
};

testFunc(test1, test2);
testFunc(test1, test3);

Console.ReadLine();