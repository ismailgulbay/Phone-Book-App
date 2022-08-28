using System;
using PhoneBook.Data;

namespace PhoneBook.Data;

public class PhoneDirectory{
    
    private static List<Person> _phoneList;
    static PhoneDirectory(){
            
        _phoneList = new List<Person>()
        {   
            new Person(){FirstName = "İsmail", LastName = "Gülbay", PhoneNumber = "0536 111 11 11"},
            new Person(){FirstName = "Melih", LastName = "Gülbay", PhoneNumber = "0544 111 11 11"},
            new Person(){FirstName = "Ünal", LastName = "Gülbay", PhoneNumber = "0546 111 11 11"},
            new Person(){FirstName = "Fatma", LastName = "Gülbay", PhoneNumber = "0534 111 11 11"},
            new Person(){FirstName = "Murat", LastName = "Gülbay", PhoneNumber = "0530 111 11 11"},
        };

    }


    public static List<Person> PhoneList{
        get { return _phoneList; }
        
    }
}

    
