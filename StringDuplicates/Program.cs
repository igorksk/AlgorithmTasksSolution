using StringDuplicates;
using System;

Console.WriteLine("Hello, World!");

Action<string> testFunc = (string s) =>
{
    bool testResult = DuplicatesChecker.CheckForDuplicates(s);

    Console.WriteLine("String " + s + (testResult ? " contains duplicates" : " doesn't contain duplicates"));
};

testFunc("qwerty");
testFunc("qwertyqu");

Console.ReadLine();