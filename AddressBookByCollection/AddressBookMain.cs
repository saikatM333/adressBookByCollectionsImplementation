using AddresBook;
using AddressBookByCollection;

public class AddressBookMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine("address book");


       MultipleAddressBookFunctionality multipleAddressBookFunctionality = new MultipleAddressBookFunctionality();
        try
        {
            while (true)
            {
                Console.WriteLine("press 0 for add contact details in exsisting or new address book\npress 1 for display of name \n press 2 for count the person by city or state\n press 3 for search by city or state   ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0: multipleAddressBookFunctionality.addContactToExsistingAddressBook(); break;
                    case 1: multipleAddressBookFunctionality.displayNameByCityandState(); break;
                    case 2: multipleAddressBookFunctionality.countPersonByCityAndState(); break;
                    case 3: multipleAddressBookFunctionality.searchByCityAndState(); break;
                }
            }

        }
        catch (Exception ex)
        {
            if (ex  is CustomException  cx)
            {
                Console.WriteLine(cx);
            }
        }

    
}
}