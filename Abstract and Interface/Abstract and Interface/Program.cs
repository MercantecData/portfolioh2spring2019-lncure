using System;
using System.Collections.Generic;

namespace Abstract_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // - Lav en abstrakt klasse med minimum én abstrakt metode i. Instantier 3 forskellige subklasser af denne.
        public abstract class test
        {
            public abstract string methodName();

        }

        public class subclass1 : test
        {
            public override string methodName()
            {
                throw new NotImplementedException();
            }
        }
        public class subclass2 : test
        {
            public override string methodName()
            {
                throw new NotImplementedException();
            }
        }
        public class subclass3 : test
        {
            public override string methodName()
            {
                throw new NotImplementedException();
            }
        }

        // - Lav et interface med 3 metoder i. Implementer dette interface i 2 forskellige classes.
        interface INewInterface
        {
            void Testing1();
            void Testing2();
            void Testing3();
        }

        public class InterfaceTest1 : INewInterface
        {

            public void Testing1()
            {
                throw new NotImplementedException();
            }

            public void Testing2()
            {
                throw new NotImplementedException();
            }

            public void Testing3()
            {
                throw new NotImplementedException();
            }
        }

        public class InterfaceTest2 : INewInterface
        {

            public void Testing1()
            {
                throw new NotImplementedException();
            }

            public void Testing2()
            {
                throw new NotImplementedException();
            }

            public void Testing3()
            {
                throw new NotImplementedException();
            }
        }

        // - Lav en liste på minimum 10 personer med Navn, Alder og Køn. Brug IComparable til at sortere efter Alder.
        public class Person : IComparable
        {
            string name;
            int age;
            bool gender; //True = male, False = female.

            public Person(string name, int age, bool gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
            }

            public int CompareTo(object obj)
            {
                Person persons = obj as Person;
                if (persons != null)
                {
                    return this.age.CompareTo(persons.age);
                }
                else
                {
                    throw new NullReferenceException("GET THIS BETA SHIT OFF MEE!! AAAAAAAH!");
                }
            }
        }

        //- Lav en liste på minimum 10 personer med Navn, Alder og Køn. Brug IComparable til at sortere efter Alder.
        public class machmudsLair
        {
            List<Person> Persons = new List<Person>();
            public machmudsLair()
            {
                Persons.Add(new Person("Machmud", 69, true));
                Persons.Add(new Person("Logan", 18, true));
                Persons.Add(new Person("Mads", 13, false));
                Persons.Add(new Person("Mark", 69, true));
                Persons.Add(new Person("Nikolaj", 34, true));
                Persons.Add(new Person("yashar", 40, true));
                Persons.Add(new Person("Pinar", 17, true));
                Persons.Add(new Person("Spankbank", 88, false));
                Persons.Add(new Person("johanne", 56, false));
                Persons.Add(new Person("jay", 89, true));
            }
        }
        // - Ændre dit program til at sortere alfabetisk. Hvis 2 personer hedder det samme, sorter efter alder. Hvis de så har samme, sorter kvinder før mænd. Brug stadig IComparable.
    }
}