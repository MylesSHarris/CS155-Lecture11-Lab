using System;
using System.Collections.Generic;

namespace Lab
{
    public class Lab
    {
        static Dictionary<String, string> dictionary = new Dictionary<string, string>();

        static void Main(string[] arguments)
        {
            AddPhoneNumber("Police", "911");

            Console.WriteLine(FindPhoneNumber("Police"));
            DeletePhoneNumber("Police");
            Console.WriteLine(FindPhoneNumber("Police"));

        }

        public static void AddPhoneNumber(string name, string number)
        {
            dictionary.Add(name, number);
        }

        public static void DeletePhoneNumber(string name)
        {
            dictionary.Remove(name);
        }

        public static string FindPhoneNumber(string name)
        {
            string number = "None";
            if (dictionary.ContainsKey(name)) dictionary.TryGetValue(name, out number);
            return number;
        }
    }
}
