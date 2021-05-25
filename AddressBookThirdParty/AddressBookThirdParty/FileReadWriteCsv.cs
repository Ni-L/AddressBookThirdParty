using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookThirdParty
{
    class FileReadWriteCsv

    {
       public static string FilePathCsv = @"C:\Users\Aishwarya\source\repos\AddressBookThirdParty\AddressBookThirdParty\AddressBookThirdParty\Csvdatatoreadandwrite.csv";
        public static void WriteCsvFile(List<Person> contacts)
        {
            if (File.Exists(FilePathCsv))
            {
                using (StreamWriter streamWriter = File.AppendText(FilePathCsv))
                {
                    foreach (Person contact in contacts)
                    {
                        streamWriter.WriteLine(contact.firstName + "," + contact.lastName + "," + contact.city + "," + contact.state + "," + contact.phoneNumber);
                    }
                }
            }
        }

        public static void ReadContactsInCSVFile()
        {
            if (File.Exists(FilePathCsv))
            {
                string[] csv = File.ReadAllLines(FilePathCsv);
                foreach (string csValues in csv)
                {
                    string[] column = csValues.Split(',');
                    foreach (string CSValues in column)
                    {
                        Console.WriteLine(CSValues);
                    }
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
    }
}
