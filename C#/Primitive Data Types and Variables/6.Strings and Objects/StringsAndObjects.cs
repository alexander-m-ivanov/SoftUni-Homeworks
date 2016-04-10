using System;

class StringsAndObjects
{
    static void Main()
    {
        string HelloVar = "Hello";
        string WorldVar = "World";
        object concat = HelloVar + " " + WorldVar;
        string HelloWorld = (string)concat;
    }
}