using System;
using PhoneBook.Data;

namespace PhoneBook.Operations;

public class UpdatingOperation{

    public void Update(){
        string? updatePerson = Console.ReadLine();
        bool check = true;
        while(check){
            Console.WriteLine("Please enter the name or surname of the person whose number you want to update.");
            var person = Console.ReadLine();
            if(CheckExist(updatePerson)){
                Person? personUpdate = PhoneDirectory.PhoneList.FirstOrDefault(x => x.FirstName == person || x.LastName == person);
                Console.WriteLine("Please enter new phone number: ");
                if(personUpdate != null) personUpdate.PhoneNumber = Console.ReadLine();
                check = false;

            }
            else Console.WriteLine("The name you searched for in the directory could not be found.");
                
        }

    }

    private bool CheckExist(string? name){
        return PhoneDirectory.PhoneList.Any(x => x.FirstName == name || x.LastName == name);
    }
}