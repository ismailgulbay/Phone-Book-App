using System;
using PhoneBook.Data;

namespace PhoneBook.Operations;

public class DeletingOperation{

    public void Delete(){
        bool check = true;

        while(check){
            Console.WriteLine("Please enter the first or last name of the person whose number you want to delete: ");
            var person = Console.ReadLine();
            if(CheckExist(person)){
                Person? personDelete = PhoneDirectory.PhoneList.FirstOrDefault(x => x.FirstName == person || x.LastName == person);
                if(YesOrNo(person)){
                    PhoneDirectory.PhoneList.Remove(personDelete);
                    Console.WriteLine("{0} has been deleted from the directory.", person);
                }
                check = false;

            }
            else{
                check = NotExist() ? true : false;
            }
        }

    }

    private bool CheckExist(string? name){
        return PhoneDirectory.PhoneList.Any(x => x.FirstName == name || x.LastName == name);
    }

    private bool YesOrNo(string person){
        Console.WriteLine("Confirming {0} to be deleted from the directory ?(y/n)", person);
        string? yesOrNo = Console.ReadLine();
        return yesOrNo == "y" ? true : false;
    }

    private bool NotExist(){
        Console.WriteLine("The name you searched for in the directory could not be found. Please make a selection.");
        Console.WriteLine("* To end the deletion : (1)");
        Console.WriteLine("* To try again        : (2)");
        
        return Convert.ToInt16(Console.ReadLine()) == 2 ? true : false;
    }
}