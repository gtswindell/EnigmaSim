using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaSim.Model
{
    public interface IEnigma
    {
        ICollection<EnigmaSim.Components.Rotor.BaseRotor> Rotors { get; }
        char DecipherCharacter(char input);
        string DecipherString(string input); 
    }
}
