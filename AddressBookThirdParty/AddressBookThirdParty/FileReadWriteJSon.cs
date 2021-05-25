using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookThirdParty
{
    class FileReadWriteJSon
    {
        public static string filePathJson = @"C:\Users\Aishwarya\source\repos\AddressBookThirdParty\AddressBookThirdParty\AddressBookThirdParty\AddressBookJson.json";
        public static void WriteContactsInJSONFile(List<Person> contacts)
        {
            if (File.Exists(filePathJson))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(filePathJson))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, contacts);
                }
                Console.WriteLine("Writting Contacts to the JSON file");
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }

        public static void ReadContactsFromJSONFile()
        {
            if (File.Exists(filePathJson))
            {
                List<Person> contactsRead = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(filePathJson));
                foreach (Person contact in contactsRead)
                {
                    Console.Write(contact.ToString());
                }
            }
            else
            {
                Console.WriteLine("No such file exists");
            }
        }
    }
}
