using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Svetlio";
        string middleName = "Plamenov";
        string lastName = "Haralampiev";
        decimal balance = 34568.34m;
        string bank = "Medicci Bank";
        string IBAN = "BG06BUIB123456789ABCDEFG";
        //The purpose of the ID is to stay unchange,
        //that is why it's put in string data type.
        //Otherwise, as numbers they coulb be held in ulong
        string card1 = "1234852136971563";
        string card2 = "3697123485211563";
        string card3 = "8521369715631234";
    }
}