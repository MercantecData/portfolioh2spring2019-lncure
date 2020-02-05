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
        public class MusePlade { }
        public class DiskLæser { }
        public class Kontroller { }
        public class SignalModtager { }
        public class InfrarødModtager { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class computer
        {
            public Processer processer;
            //public Hukommelse memory[]
            //public Lagerplads storage[]
            //Public Io port[]

            static void TurnOn()
            {

            }

            static void TurnOff()
            {

            }

        }

        public class Stationær
        {
            //public Kabinet case
            //public AtxForsyning atxPower
            //public Køler cooling
        }

        public class Bærbar
        {
            //Public skærm screen
            //public kamera camera
            //public MusePlade Touchpad

            static void Close()
            {

            }
            
            static void Open()
            {

            }
        }

        public class Mobiltelefon
        {
            //public TouchSkærm touchScreen
            //public Kamera camera[]
            //public EmsModtager EmsReciever
            //public Raid shadowLegends

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

            public class SmartWatch
            {
                //public TouchSkærm touchScreen
                //public Kamera camera

                static void Lock()
                {

                }

                static void Unlock()
                {

                }
            }

            public class Konsol
            {
                //public DiskLæser diskReader
                //public Kontroller controller

                static void ChangeDisk()
                {

                }
            }

            public class SmartTV
            {
                //public Skærm screen
                //public SignalModtager signalReciever
                //public InfrarødModtager infraredReciever

                static void ChangeChannel()
                {

                }
            }
        }
    }
}
