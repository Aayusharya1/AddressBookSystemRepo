using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AddressBookSystem
{
    class FileOperations
    {
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\Aayush Arya\source\repos\AdressBookSystem\AdressBookSystem\ContactFilesFolder\Contacts.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String fileData = "";
                    while ((fileData = sr.ReadLine()) != null)
                        Console.WriteLine((fileData));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        public static void WriteUsingStreamWriter(List<string> data)
        {
            string path = @"C:\Users\Aayush Arya\source\repos\AdressBookSystem\AdressBookSystem\ContactFilesFolder\Contacts.txt";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    
                    foreach(var contact in data) 
                    {
                        streamWriter.WriteLine(contact);
                    }
                    
                    streamWriter.Close();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }

        public static void ImplementCSVDataHandling()
        {
            string filePath = @"C:\Users\Aayush Arya\source\repos\AdressBookSystem\AdressBookSystem\ContactFilesFolder\Contacts.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Data Reading done successfully from Contact.csv file");
                foreach (Contact contact in records)
                {
                    Console.Write("\t" + contact.firstName);
                    Console.Write("\t" + contact.lastName);
                    Console.Write("\t" + contact.address);
                    Console.Write("\t" + contact.city);
                    Console.Write("\t" + contact.state);
                    Console.Write("\t" + contact.zip);
                    Console.Write("\t" + contact.phoneNumber);
                    Console.Write("\t" + contact.email);
                    Console.Write("\n");
                }
            }
        }
        public static void WriteCSVFile(List<string> data)
        {
            string filePath = @"C:\Users\Aayush Arya\source\repos\AdressBookSystem\AdressBookSystem\ContactFilesFolder\Contacts.csv";
            using (var writer = new StreamWriter(filePath))
            using (var csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                Console.WriteLine("Data Writing done successfully from Contact.csv file");
                csvWrite.WriteRecord(data);
            }
        }
        //Read a JSON File
        public static void ReadJsonFile()
        {
            string filePath = @"";
            if (File.Exists(filePath))
            {
                IList<Contact> contactsRead = JsonConvert.DeserializeObject<IList<Contact>>(File.ReadAllText(filePath));
                foreach (Contact contact in contactsRead)
                {
                    Console.Write("\t" + contact.firstName);
                    Console.Write("\t" + contact.lastName);
                    Console.Write("\t" + contact.address);
                    Console.Write("\t" + contact.city);
                    Console.Write("\t" + contact.state);
                    Console.Write("\t" + contact.zip);
                    Console.Write("\t" + contact.phoneNumber);
                    Console.Write("\t" + contact.email);
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
        }
        //Write to a JSON File
        public static void WriteToJsonFile(List<Contact> data)
        {
            string filePath = @"";
            if (File.Exists(filePath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, data);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
        }
    }
}
      
