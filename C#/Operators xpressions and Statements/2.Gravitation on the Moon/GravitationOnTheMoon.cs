using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = weightEarth * 0.17;
        Console.WriteLine(weightMoon);
    }
}