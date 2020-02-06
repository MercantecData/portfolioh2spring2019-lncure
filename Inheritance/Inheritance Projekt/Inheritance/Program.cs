using System;

namespace Inheritance
{
    class Program
    {
        public class Processer { }
        public class Hukommelse { }
        public class LagerPlads { }
        public class Io { }
        public class Kabinet { }
        public class AtxForsyning { }
        public class Køler { }
        public class Skærm { }
        public class Kamera { }
        public class TouchSkærm { }
        public class EmsModtager { }
        public class Raid { }
        public class MusePlade { }
        public class DiskLæser { }
        public class Kontroller { }
        public class SignalModtager { }
        public class InfrarødModtager { }

        //--------------------------------------------------------
        static void Main(string[] args)
        {
            Computer myComputer = new Stationær();
        }
        //---------------------------------------------------------
        abstract class Computer
        {
            public Processer processer;
            public Hukommelse memory[];
            public LagerPlads storage[];
            public Io port[];

            static void TurnOn()
            {

            }

            static void TurnOff()
            {

            }

        }

        public class Stationær : Computer
        {
            public Kabinet cabinet;
            public AtxForsyning atxPower;
            public Køler cooling;
        }

        public class Bærbar : Computer
        {
            public Skærm screen;
            public Kamera camera;
            public MusePlade Touchpad;

            static void Close()
            {

            }

            static void Open()
            {

            }
        }

        public class Mobiltelefon : Computer
        {
            public TouchSkærm touchScreen;
            public Kamera camera[];
            public EmsModtager EmsReciever;
            public Raid shadowLegends;

            static void Lock()
            {

            }

            static void Unlock()
            {

            }

            static void SendMessage()
            {

            }

            static void RecieveMessage()
            {

            }
            static void MakeCall()
            {

            }

            static void AcceptCall()
            {

            }

            public class SmartWatch : Computer
            {
                public TouchSkærm touchScreen;
                public Kamera camera;

                static void Lock()
                {

                }

                static void Unlock()
                {

                }
            }

            public class Konsol : Computer
            {
                public DiskLæser diskReader;
                public Kontroller controller;

                static void ChangeDisk()
                {

                }
            }

            public class SmartTV : Computer
            {
                public Skærm screen;
                public SignalModtager signalReciever;
                public InfrarødModtager infraredReciever;

                static void ChangeChannel()
                {

                }
            }

            // - Lav et interface med 3 metoder i. Implementer dette interface i 2 forskellige classes.
            interface newInterface
            {
                void testing1();
                void testing2();
                void testing3();
            }

            // - Lav en abstrakt klasse med minimum én abstrakt metode i. Instantier 3 forskellige subklasser af denne.
            public abstract class test
            {
                public abstract string methodName();

            }

            public class test1 : test, newInterface
            {
                public override string methodName()
                {
                    Console.WriteLine("yeet from test 1");
                }
            }

            public class test2 : test, newInterface
            {
                public override string methodName()
                {
                    Console.WriteLine("yeet from test 2");
                }
            }

            public class test3 : test
            {
                public override string methodName()
                {
                    Console.WriteLine("yeet from test 3");
                }
            }

            // - Lav en liste på minimum 10 personer med Navn, Alder og Køn. Brug IComparable til at sortere efter Alder.
            public class Person
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
            }

            public class fuckingHelp : IComparable<Person>
            {
                var persons = new List<Person>();
                public fuckingHelp()
                {
                    persons.Add(new Person("Machmud", 69, true));
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
        }
    }
}
