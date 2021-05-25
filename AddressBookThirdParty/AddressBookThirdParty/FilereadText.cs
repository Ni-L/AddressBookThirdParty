using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookThirdParty
{
    /// <summary>
    /// For read write file
    /// </summary>
    class FilereadText
    {
        /// <summary>
        /// giving the path of the file which is read or write
        /// </summary>
        public static string FilePath = @"C:\Users\Aishwarya\source\repos\AddressBookThirdParty\AddressBookThirdParty\AddressBookThirdParty\AddressBook.txt";

        //Adding Method for WriteTextFile
        public static void WriteTextFile(List<Person> personlist)
        {
            if (File.Exists(FilePath))//Chaeck if file exist or not
            {
                //StreamWriter that shows how to write text from a file
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    foreach (Person person in personlist)
                    {
                        sw.WriteLine(" __________________\nPersons detail_____________________ ");
                        sw.WriteLine("FirstName: " + person.firstName);
                        sw.WriteLine("LastName: " + person.lastName);
                        sw.WriteLine("City    : " + person.city);
                        sw.WriteLine("Email   : " + person.state);
                        sw.WriteLine("State   : " + person.email);
                        sw.WriteLine("PhoneNum: " + person.phoneNumber);
                        sw.WriteLine("Zip   : " + person.zip);

                    }
                    //Closses StreamWriter object
                    sw.Close();
                }
                Console.WriteLine(" Persons detail in to the Text the file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        //Adding Method For Reading Text File
        public static void ReadTextFile()
        {
            if (File.Exists(FilePath))//Check for file exist or not 
            {
                //  StreamReader that shows how to read text from a file
                using (StreamReader readstreamReader = File.OpenText(FilePath))
                {
                    String personDetails = "";
                    while ((personDetails = readstreamReader.ReadLine()) != null)
                        Console.WriteLine((personDetails));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

    }
}