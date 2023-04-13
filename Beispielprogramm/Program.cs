using System;
using System.Threading;

namespace ClassObject
{
    class Dog // class                      // Klasse
    {
        // fields                           // Eigenschaften/Attribute
        public int age;                     // Alter
        public string name;                 // Name
        public string breed;                // Rasse

        // methods                          // Methoden/Funktionen
        public void sleep()                 // schlafen
        {
            Thread.Sleep(1000);             // dein Programmcode
            Console.WriteLine("*schlafen*");
        }
        public void bark()                  // bellen
        {
            Console.Beep(5000, 2000);       // dein Programmcode
        }
    }

    class Program
    {
        /// <summary>
        /// Beispielprogramm zu Klassen (Class) / Objekten (Object)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)     // Hauptprogramm
        {
            // create Dog object            // Hund-Objekt erzeugen
            Dog myFirstDog = new Dog();     // meinErsterHund

            // set name of dog              // Name des Hundes festlegen
            myFirstDog.name = "Hektor";     // string

            // set age of dog               // Alter des Hundes festlegen
            myFirstDog.age = 13;            // integer

            // set breed of dog             // Rasse des Hundes festlegen
            myFirstDog.breed = "Dalmatian"; // string

            // access method of dog         // Zugriff auf Methode von Hunden
            myFirstDog.sleep();             // Hund beginnt zu schlafen
            myFirstDog.bark();              // Hund beginnt zu bellen

            // get name of dog              // Name des Hundes abfragen
            Console.WriteLine(myFirstDog.name);


            // create Dog object            // Hund-Objekt erzeugen
            Dog mySecondDog = new Dog();    // meinZweiterHund

            // set breed of dog             // Rasse des Hundes festlegen
            mySecondDog.breed = "Poodle";   // string

            /*
            etc.
            etc.
            etc.
             */

            #region Damit die Konsole sich nicht schliesst
            Console.WriteLine(Environment.NewLine + "Press any key to close programme.");
            Console.ReadKey();
            #endregion
        }
    }
}