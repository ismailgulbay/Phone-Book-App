using System;
using PhoneBook.Operations;

namespace PhoneBook{

    class Program{

        static void Main(string[] args){
            Console.WriteLine("Please choose the action you want to do: ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Register new number");
            Console.WriteLine("(2) Delete existing number");
            Console.WriteLine("(3) Update existing number");
            Console.WriteLine("(4) List the directory");
            Console.WriteLine("(5) Search the directory");


            int? choice = Convert.ToInt16(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    var addingOperation = new AddingOperation();
                    addingOperation.Add();
                    break;
                case 2:
                    var deletingOperation = new DeletingOperation();
                    deletingOperation.Delete();
                    break;
                case 3:
                    var updatingOperation = new UpdatingOperation();
                    updatingOperation.Update();
                    break;
                case 4:
                    var listingOperation = new ListingOperation();
                    listingOperation.List();
                    break;
                case 5:
                    var searchingOperation = new SearchingOperation();
                    searchingOperation.Search();
                    break;

            }


        }
    }
}