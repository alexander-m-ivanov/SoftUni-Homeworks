using System;

class NullableTypes
{
    static void Main()
    {
        int? nullValue = null;
        double? nullDouble = null;
        Console.WriteLine("Print nullValue -->" + nullValue);
        Console.WriteLine("Print nullDouble -->" + nullDouble);
        nullValue = 135;
        nullDouble = 12.36;
        Console.WriteLine(new string ('-', 50));
        Console.WriteLine("Print nullValue with assiged number-->" + nullValue);
        Console.WriteLine("Print nullDouble with assiged number-->" + nullDouble);
    }
}
