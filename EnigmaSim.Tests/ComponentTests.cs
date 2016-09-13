using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnigmaSim.Tests
{
    [TestClass]
    public class ComponentTests
    {
        [TestMethod]
        public void BasicRotorTests()
        {
            EnigmaSim.Components.Rotor.RotorCollection rotors = new EnigmaSim.Components.Rotor.RotorCollection();
            Assert.AreEqual<int>(10, rotors.Count(), "Invalid number of rotors");

            EnigmaSim.Components.Rotor.BaseRotor rotor = rotors["Rotor VI"];
            Assert.AreEqual<string>("Rotor VI", rotor.Name, "Invalid Rotor Name");
            Assert.AreEqual<char>('Q', rotor['J'], "Invalid character mapping");
        }


        [TestMethod]
        public void BasicReflectorTests()
        {
            EnigmaSim.Components.Reflector.ReflectorCollection reflectors = new Components.Reflector.ReflectorCollection();
            Assert.AreEqual<int>(4, reflectors.Count(), "Invalid number of reflectors");

            EnigmaSim.Components.Reflector.BaseReflector reflector = reflectors["reflector C"];
            Assert.AreEqual<string>("reflector C", reflector.Name, "Invalid Reflector Name");
            Assert.AreEqual<char>('J', reflector['D'], "Invalid character mapping");
            Assert.AreEqual<char>('L', reflector['Z'], "Invalid character mapping");
        }


    }
}
