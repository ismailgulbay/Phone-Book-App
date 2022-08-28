using System;
using PhoneBook.Data;


namespace PhoneBook.Operations;

public class ListingOperation{

    public void List(){
        Console.WriteLine("Phone Book");
        Console.WriteLine("**********************************************");

        foreach(Person item in PhoneDirectory.PhoneList){
            Console.WriteLine("First Name : {0}", item.FirstName);
            Console.WriteLine("Last Name : {0}", item.LastName);
            Console.WriteLine("Phone Number : {0}", item.PhoneNumber);
            Console.WriteLine("-");
        }
    }



}