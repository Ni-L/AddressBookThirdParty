using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookThirdParty
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("_________________Welcome in Address book System____________________");
            Console.WriteLine("***********************************************************************");
            //Declaring Dictionary of name addingcontact
            //In AddressBook declared methods for adding,seraching,Display,Delete and more
            //Dictionary stores Key ValuePair String is Key and AddressBook is value
            Dictionary<string, AddressBookMethods> mydictionarycontact = new Dictionary<string, AddressBookMethods>();

            //How many Address Book You want to Create Thats why Give Inpute
            Console.WriteLine("\nHow many address Book you want  : ");
            //Coverting string into int with the help of Toint32
            int numofAddressBooks = Convert.ToInt32(Console.ReadLine());
            //For checking NumberofAddressBooks
            //Taking local variable i to check
            for (int i = 1; i <= numofAddressBooks; i++)
            {
                //Take variable Name addressbookName for input Readline                
                Console.WriteLine("Enter the name of address book " + i + ": ");
                string addressbookName = Console.ReadLine();
                //Creating Object for AddressBookMethods Class
                AddressBookMethods addressBook = new AddressBookMethods();
                //Adding addressbookName to the disctionary
                mydictionarycontact.Add(addressbookName, addressBook);
            }
            Console.WriteLine("\nYou have created Address Books : ");
            //var is used to store any data type value,var can be set and retrive

            foreach (var item in mydictionarycontact)
            {
                Console.WriteLine("{0}", item.Key);
            }
            //Boolean Represents true or false value 
            bool Result = true;
            //Initialised While loop after declaring count of disctionary 
            //IF it is true then following will be excecute otherwise exit
            while (Result)
            {
                Console.WriteLine("______________________________________________________________________");
                //Choosing Option for what you want 
                Console.WriteLine("\nChoose option \n1.Add Contact " +
                    "\n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts" +
                    " \n5.Search Person By City & State \n6.Display Contacts Same City " +
                    "\n7.Display Contacts Same State \n8.View number of contacts of city and state " +
                    " \n9.Display Contacts in Sorted " +
                     "\n10.Display contact in sorted by state or by city " +
                      "\n11.File Operation " +
                      "\n12.Read Write Operation inCsv \n13.Read Write Operation in Json file \n14.Exit");
                Console.WriteLine("_______________________________________________________________________");
                //Inside While declare one variable of name choice
                //Create as a Readline for user input
                int choice = Convert.ToInt32(Console.ReadLine());
                //Switch statement for user choice
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Any Existing Address Book Name for adding contacts");
                        //Creating variable string type 
                        string contactName = Console.ReadLine();
                        //Determine whether the dictionary contains contactName or not specified key
                        //If contains that name then 
                        //Asked for How many number of contactName you want to add 
                        if (mydictionarycontact.ContainsKey(contactName))
                        {
                            Console.WriteLine("\nEnter the number of contacts you want to add in AddressBook");
                            //taking input from user and convert into int with the help of ToInt32()
                            //Create one local variable
                            int numberOfContactsName = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= numberOfContactsName; i++)
                            {
                                addContactBook(mydictionarycontact[contactName]);
                            }
                            //show contactName and displayPerson
                            mydictionarycontact[contactName].displayPerson();
                        }
                        //If the name not exist 
                        else
                        {
                            Console.WriteLine("No AddressBook exist with name {0}", contactName);
                        }
                        break;
                    case 2:
                        //If user wants to edit the deatils of contact
                        Console.WriteLine("Enter Address Book Name for edit contact");
                        //Create one local Variable editcontactName 
                        string editcontactName = Console.ReadLine();
                        //check whether the dictionary contains Name or not specified key
                        //if contains name then edit contact 
                        //if not contain then no addressbook there present 
                        if (mydictionarycontact.ContainsKey(editcontactName))
                        {
                            //call editperson to edit
                            mydictionarycontact[editcontactName].editPerson();
                            //call  display method to display
                            mydictionarycontact[editcontactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                        }
                        break;
                    case 3:
                        //If UserWant to delete contact then
                        //Enter the AddressBook Name to delete the contact
                        Console.WriteLine("\nEnter Address Book Name for delete contact");
                        //create one local variable to read
                        string deleteContact = Console.ReadLine();
                        //if it conatins then delete the contact
                        //Otherwise display not present
                        if (mydictionarycontact.ContainsKey(deleteContact))
                        {
                            mydictionarycontact[deleteContact].deletePerson();
                            mydictionarycontact[deleteContact].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                        }
                        break;
                    case 4:
                        //If User Wants to Display Contact
                        Console.WriteLine("\nEnter Address Book Name for display contacts");
                        string displayContactsInBook = Console.ReadLine();
                        mydictionarycontact[displayContactsInBook].displayPerson();
                        break;
                    case 5:
                        //
                        Console.WriteLine("\n Enter address book name for searching Contact:");
                        string searchContacts = Console.ReadLine();
                        if (mydictionarycontact.ContainsKey(searchContacts))
                        {
                            mydictionarycontact[searchContacts].searchPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", searchContacts);
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n Enter address book name for city:");
                        string displayCityContacts = Console.ReadLine();
                        if (mydictionarycontact.ContainsKey(displayCityContacts))
                        {
                            mydictionarycontact[displayCityContacts].sameCityPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayCityContacts);
                        }
                        break;
                    case 7:
                        Console.WriteLine("\n Enter address book name for state:");
                        string displayContacts = Console.ReadLine();
                        if (mydictionarycontact.ContainsKey(displayContacts))
                        {
                            mydictionarycontact[displayContacts].sameStatePerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayContacts);
                        }
                        break;
                    case 8:
                        Console.WriteLine("\n Enter address book name :For counting same city or state");
                        string displayCountContacts = Console.ReadLine();
                        if (mydictionarycontact.ContainsKey(displayCountContacts))
                        {
                            mydictionarycontact[displayCountContacts].findCountSameStateOrCityPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayCountContacts);
                        }
                        break;

                    case 9:
                        Console.WriteLine("\nEnter Address Book Name for display contacts in sorted order");
                        string sortorder = Console.ReadLine();
                        mydictionarycontact[sortorder].displayPersonInOrder();
                        break;

                    case 10:
                        Console.WriteLine("\nEnter Address Book Name for Sort contacts based on City or State");
                        string nameAddressBookforSorting = Console.ReadLine();
                        Console.WriteLine("\nChoose option for sorting \n1.By City  \n2.By State \n3.By Zip");
                        int choiceSorting = Convert.ToInt32(Console.ReadLine());
                        switch (choiceSorting)
                        {
                            case 1:
                                mydictionarycontact[nameAddressBookforSorting].displayPersonInOrderByCity();
                                break;
                            case 2:
                                mydictionarycontact[nameAddressBookforSorting].displayPersonInOrderByState();
                                break;
                            case 3:
                                mydictionarycontact[nameAddressBookforSorting].displayPersonInOrderByZip();
                                break;
                        }
                        break;
                    case 11:
                        Console.WriteLine("chioce : \n1.Write Person detail in text file \n2 Read Person detail from text file");
                        int chooseOption = Convert.ToInt32(Console.ReadLine());
                        switch (chooseOption)
                        {
                            case 1:
                                Console.WriteLine("Enter Address Book name where you want to write person details");
                                string write = Console.ReadLine();
                                if (mydictionarycontact.ContainsKey(write))
                                {
                                    mydictionarycontact[write].WritePersonDetailTextFile();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", write);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Address Book name where you want to write person details");
                                string read = Console.ReadLine();
                                if (mydictionarycontact.ContainsKey(read))
                                {
                                    mydictionarycontact[read].ReadPersonDetailTxtFile();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", read);
                                }
                                break;

                            default:
                                Console.WriteLine("Please enter valid option only");
                                break;
                        }
                        break;

                    case 12:
                        Console.WriteLine("chioce : \n1.Write Person detail in Csv file \n2 Read Person detail from Csv file");
                        int chooseOptionforreadwritecsv = Convert.ToInt32(Console.ReadLine());
                        switch (chooseOptionforreadwritecsv)
                        {
                            case 1:
                                Console.WriteLine("Enter Address Book name where you want to write person details");
                                string writecsv = Console.ReadLine();
                                if (mydictionarycontact.ContainsKey(writecsv))
                                {
                                    mydictionarycontact[writecsv].WriteCsvFile();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", writecsv);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Address Book name where you want to write person details");
                                string read = Console.ReadLine();
                                if (mydictionarycontact.ContainsKey(read))
                                {
                                    mydictionarycontact[read].ReadContactsInCSVFile();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", read);
                                }
                                break;

                            default:
                                Console.WriteLine("Please enter valid option only");
                                break;
                        }
                        break;
                    case 13:
                        Console.WriteLine("chioce : \n1.Write Person detail in Json file \n2 Read Person detail from Json file");
                        int chooseOption3 = Convert.ToInt32(Console.ReadLine());
                        switch (chooseOption3)
                        {
                            case 1:
                                Console.WriteLine("Enter Address Book name where you want to write person details");
                                string writejson = Console.ReadLine();
                                if (mydictionarycontact.ContainsKey(writejson))
                                {
                                    mydictionarycontact[writejson].WriteContactsInJSONFile();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", writejson);
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Address Book name where you want to write person details");
                                string read = Console.ReadLine();
                                if (mydictionarycontact.ContainsKey(read))
                                {
                                    mydictionarycontact[read].ReadContactsFronJSON();
                                }
                                else
                                {
                                    Console.WriteLine("No Address book exist with name {0} ", read);
                                }
                                break;

                            default:
                                Console.WriteLine("Please enter valid option");
                                break;
                        }
                        break;

                    case 14:
                        Result = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }
            }
            void addContactBook(AddressBookMethods addressBook)
            {
                Console.WriteLine("Enter First Name : ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name : ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Address : ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City : ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State : ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Phone Number : ");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email id :");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Zip : ");
                int zip = Convert.ToInt32(Console.ReadLine());
                addressBook.AddContact(firstName, lastName, address, city, state, phoneNumber, email, zip);
            }

        }
    }
}
