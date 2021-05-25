using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookThirdParty
{/// <summary>
/// Creating Class For Adding Methods
/// </summary>
    class AddressBookMethods
    {
        /// <summary>
        /// Creating List and Storing Values in list
        /// Declaring AddContacts,DisplayPerson,DeletePerson,SearchPerson And Edit Person methods
        /// </summary>
        //Adding list of name listofcontact
        List<Person> listofcontacts = new List<Person>();
        //Adding method for Add contact to the list
        public AddressBookMethods()//default constructor
        {
            this.listofcontacts = new List<Person>();
        }
        public void AddContact(string firstName, string lastName, string address, string city, string state, long phoneNumber, string email, int zip)
        {
            //bool for setting true or false value
            //setting the list
            //Any means whether the condition satisfy or not
            bool flag = this.listofcontacts.Any(item => item.firstName == firstName && item.lastName == lastName);
            if (!flag)
            {
                //create new object of person class
                Person person = new Person(firstName, lastName, city, state, email, phoneNumber, zip);
                //adding person details in List 
                listofcontacts.Add(person);
                Console.WriteLine("Contact added Successfully");
            }
            else
            {
                Console.WriteLine("{0}{1} this contact already exist in Address Book :", firstName, lastName);
            }
        }
        public void displayPerson()//ForDisplay Person
        {
            Console.WriteLine("\nEntered Person Details is:");
            foreach (var person in listofcontacts)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }
        //Adding displayPersonInOrder
        public void displayPersonInOrder()
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            //orderBy sorts the vlues of collection in ascending or decending order
            foreach (var person in listofcontacts.OrderBy(Key => Key.firstName))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber);
            }
        }
        public void displayPersonInOrderByCity()//Display person In Order by City
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            //(parameter)person key
            //oredrby is a inbuild fuction for asending and descending ordr
            foreach (var person in listofcontacts.OrderBy(Key => Key.city))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}, Zip:{6}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber, person.zip);
            }
        }
        public void displayPersonInOrderByState()//Display person by State
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            //(parameter)person key
            //oredrby is a inbuild fuction for asending and descending ordr
            foreach (var person in listofcontacts.OrderBy(Key => Key.state))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}, Zip:{6}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber, person.zip);
            }
        }
        public void displayPersonInOrderByZip()//
        {
            Console.WriteLine("\nEntered Person Details is in Order :");
            //(parameter)person key
            //oredrby is a inbuild fuction for asending and descending ordr
            foreach (var person in listofcontacts.OrderBy(Key => Key.zip))
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, city: {2}, state: {3}, email: {4}, phoneNumber: {5}, Zip:{6}", person.firstName, person.lastName, person.city, person.state, person.email, person.phoneNumber, person.zip);
            }
        }
        public void searchPerson()//ForSerachingPerson
        {
            Console.WriteLine("\n Enter city or state ");
            string city = Console.ReadLine();
            string state = Console.ReadLine();
            //findall method is used to retrive all the elements that match the conditions define the specified predeicate
            //ToList=That contains element from input  
            foreach (Person person in listofcontacts.FindAll(item => item.city == city && item.state == state).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.firstName, person.lastName);
            }
        }

        public void sameCityPerson()//Adding method for Person in same city
        {
            Console.WriteLine("\n Enter city for display Same city contacts ");
            string city = Console.ReadLine();
            foreach (Person person in listofcontacts.FindAll(item => item.city == city).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.firstName, person.lastName);
            }
        }

        public void sameStatePerson()//Adding method if person belongs to same State
        {
            Console.WriteLine("\n Enter state for display Same State contacts ");
            string stateCheck = Console.ReadLine();
            foreach (Person person in listofcontacts.FindAll(item => item.state == stateCheck).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.firstName, person.lastName);
            }
        }


        public void findCountSameStateOrCityPerson()
        {
            Console.WriteLine("\n Enter city name");
            string city = Console.ReadLine();
            Console.WriteLine("\n Enter State name");
            string state = Console.ReadLine();
            int countforcitystate = 0;
            foreach (Person person in listofcontacts.FindAll(item => item.city == city && item.state == state).ToList())
            {
                Console.WriteLine("\n{0}\t{1}", person.firstName, person.lastName);
                countforcitystate++;
            }
            Console.WriteLine("This {0} persons are in same state {1} \t {2} ", countforcitystate, state, city);
        }
        public void deletePerson()//Adding Method for deleting Person
        {
            Console.WriteLine("Enter firstName of the user you want to Delete");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname of the user you want to Delete");
            var lastName = Console.ReadLine();
            listofcontacts.RemoveAll(item => item.firstName == firstName && item.lastName == lastName);
        }

        public void WritePersonDetailTextFile()//Adding WriteDetails to text file
        {
            FilereadText.WriteTextFile(listofcontacts);
        }

        public void ReadPersonDetailTxtFile()//Adding Readdetails to text file
        {
            FilereadText.ReadTextFile();
        }
        public void ReadContactsInCSVFile()
        {
            FileReadWriteCsv.ReadContactsInCSVFile();
        }
        public void WriteCsvFile()
        {
            FileReadWriteCsv.WriteCsvFile(listofcontacts);
        }
        public void editPerson()//Adding EditPerson Method
        {
            Console.WriteLine("\n Enter First name to edit details:");
            string nametobeedit = Console.ReadLine();
            foreach (var person in listofcontacts)
            {
                if (nametobeedit.Equals(person.firstName))
                {
                    Console.WriteLine("**********************************************************");
                    Console.WriteLine("___________Choose one of the following options:____________ ");
                    Console.WriteLine("#1 Edit Phone Number");
                    Console.WriteLine("#2 Edit Email");
                    Console.WriteLine("#3 Edit City");
                    Console.WriteLine("#4 Edit State");
                    Console.WriteLine("#5 Quit");
                    Console.WriteLine("**********************************************************");
                    int userchoice = Convert.ToInt32(Console.ReadLine());
                    switch (userchoice)
                    {
                        case 1:
                            Console.WriteLine("Enter new Mobile number:");
                            long mobileNo = Convert.ToInt64(Console.ReadLine());
                            person.setPhoneNumber(mobileNo);
                            Console.WriteLine("Mobile number is updated\n");
                            break;
                        case 2:
                            Console.WriteLine("Enter new Email-id:");
                            String email = Console.ReadLine();
                            person.setEmail(email);
                            Console.WriteLine("Email-id is updated\n");
                            break;
                        case 3:
                            Console.WriteLine("Enter your city");
                            String city = Console.ReadLine();
                            person.setCity(city);
                            break;
                        case 4:
                            Console.WriteLine("Enter your state");
                            String state = Console.ReadLine();
                            person.setState(state);
                            Console.WriteLine("Address is updated\n");
                            break;
                        default:
                            Console.WriteLine("please enter right choice");
                            break;
                    }
                }
            }
        }

    }
}