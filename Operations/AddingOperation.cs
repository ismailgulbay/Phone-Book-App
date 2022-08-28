using System;
using PhoneBook.Data;

namespace PhoneBook.Operations;

public class AddingOperation{

    public void Add()
    {
        Console.WriteLine("Enter name: ");
        string? FirstName = Console.ReadLine();
    
        Console.WriteLine("Enter surname: ");
        string? LastName = Console.ReadLine();

        Console.WriteLine("Enter phone number: ");
        string? PhoneNumber = Console.ReadLine();


        var person = new Person();
        FirstName = person.FirstName;
        LastName = person.LastName;
        PhoneNumber = person.PhoneNumber;


        
        if(!CheckExist(person)) PhoneDirectory.PhoneList.Add(person);
        else Console.WriteLine("There is already a person with this name or surname."); 
    }

    private bool CheckExist(Person input){
        return PhoneDirectory.PhoneList.Any(x => x.FirstName == input.FirstName && x.LastName == input.LastName) ? true : false;
    }
}


