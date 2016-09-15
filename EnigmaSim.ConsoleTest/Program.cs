using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GTSoft.EnigmaSim.Model;
using GTSoft.EnigmaSim.EnigmaEngine;

namespace EnigmaSim.ConsoleTest
{
    class Program
    {

        private static GTSoft.EnigmaSim.Components.Rotor.BaseRotor Rotor(string name, GTSoft.EnigmaSim.Model.IEnigma engine)
        {
            var rotor = (from r in engine.Rotors
                         where r.Name == name
                         select r).First();
            return rotor;
        }

        static void Main(string[] args)
        {
            string fastRotorName = "Rotor III";
            string middleRotorName = "Rotor II";
            string slowRotorName = "Rotor I";
            string reflectorName = "reflector B";
            IEnigma target = new Basic3Wheel(fastRotorName, middleRotorName, slowRotorName, reflectorName);

            Rotor(fastRotorName, target).SetWheelOffset('K');
            Rotor(middleRotorName, target).SetWheelOffset('C');
            Rotor(slowRotorName, target).SetWheelOffset('M');

            //char result = target.DecipherCharacter('E');

            string result = target.DecipherString("QMJIDO MZWZJFJR");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
