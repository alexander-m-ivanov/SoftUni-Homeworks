using System;

namespace _4.Elevator
{
    class Elevator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int allCourses = 0;
            int fullCourses = n / p;
            int divRemain = n % p;
            bool partialCourse = divRemain != 0;

            if (partialCourse)
            {
                allCourses = fullCourses + 1;
                Console.WriteLine(allCourses);
            }
            else
            {
                Console.WriteLine(fullCourses);
            }
        }
    }
}
