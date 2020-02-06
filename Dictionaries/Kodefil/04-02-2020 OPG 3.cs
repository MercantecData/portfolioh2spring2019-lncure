using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        //  - BONUS: Lav en klasse der kan gemme et navn og en alder på en person. Lav et dictionary som bruger denne klasse som key. 
        static void Main(string[] args)
        {
            Dictionary<Person, bool> testionary = new Dictionary<Person, bool>();
            
            Person clyde = new Person("Clyde", 12);
            Person Jerome = new Person("Jerome", 17);
            Person Tyrone = new Person("Tyrone", 10);
            Person Laquisha = new Person("Laquisha", 13);
            Person Shaniqua = new Person("Shaniqua", 23);
            Person Vagisil = new Person("Vagisil", 6);
            Person Machmud = new Person("Machmud", 34);
            Person Yashar = new Person("Yashar", 69);
            Person Trinity = new Person("Trinity", 90);
            Person Steve = new Person("Steve", 420);

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
    }
    public class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
