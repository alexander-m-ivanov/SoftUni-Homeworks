using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string secondName = "Petrov";
        int age = 35;
        char gender = 'M';
        //the purpose of the ID is to stay unchange,
        //that is why it's put in string data type.
        //Otherwise, as numbers they coulb be held in ulong
        string personalID = "8306112507";
        string employeeID = "27569999";
        Console.WriteLine(" First name: {0}\n Second name: {1}\n Age: {2}\n Gender: {3}\n Personal ID: {4}\n Employee Id{5}\n"
        , firstName, secondName, age, gender, personalID, employeeID);
    }
}