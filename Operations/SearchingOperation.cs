using System;
using PhoneBook.Data;

namespace PhoneBook.Operations;

public class SearchingOperation{

    public void Search(){
        Console.WriteLine("Select your type to search.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("To search by first name or last name: (1)");
        Console.WriteLine("To search by phone number:            (2)");
        int? input = Convert.ToInt32(Console.ReadLine());

        if(input == 1){
            Console.WriteLine("Enter first name or last name : ");
            string? name = Console.ReadLine();
            Person? person = PhoneDirectory.PhoneList.FirstOrDefault(x => x.FirstName == name || x.LastName == name);
            Show(person);

        }else{
            Console.WriteLine("Enter phone number: ");
            string? number = Console.ReadLine();
            Person? person = PhoneDirectory.PhoneList.FirstOrDefault(x => x.PhoneNumber == number);
            Show(person);
        }

    }

    public void Show(Person person){
        if(person != null){
             Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone number: " + person.PhoneNumber);
        
        }
        else Console.WriteLine("There were no results.");

    }


}