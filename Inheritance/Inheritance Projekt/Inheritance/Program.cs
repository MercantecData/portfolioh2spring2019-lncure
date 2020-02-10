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
        }
    }
}
