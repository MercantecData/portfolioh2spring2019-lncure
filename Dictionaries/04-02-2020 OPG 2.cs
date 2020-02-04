using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        //  - BONUS: Lav en klasse der kan gemme et navn og en alder på en person. Lav et dictionary som bruger denne klasse som key. 
        static void Main(string[] args)
        {
            Dictionary<person, bool> testionary = new Dictionary<person, bool>();
            
            person clyde = new person("Clyde", 12);
            person Jerome = new person("Jerome", 17);
            person Tyrone = new person("Tyrone", 10);
            person Laquisha = new person("Laquisha", 13);
            person Shaniqua = new person("Shaniqua", 23);
            person Vagisil = new person("Vagisil", 6);
            person Machmud = new person("Machmud", 34);
            person Yashar = new person("Yashar", 69);
            person Trinity = new person("Trinity", 90);
            person Steve = new person("Steve", 420);

            testionary[clyde] = true;
            testionary[Jerome] = false;
            testionary[Tyrone] = true;
            testionary[Laquisha] = false;
            testionary[Shaniqua] = true;
            testionary[Vagisil] = false;
            testionary[Machmud] = true;
            testionary[Yashar] = false;
            testionary[Trinity] = true;
            testionary[Steve] = false;
        }
        public class person
        {
            string name;
            int age;

            public person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
