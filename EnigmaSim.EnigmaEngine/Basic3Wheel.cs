using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnigmaSim.Components.Utils;

namespace EnigmaSim.EnigmaEngine
{
    public class Basic3Wheel : EnigmaSim.Model.IEnigma
    {
        private EnigmaSim.Components.Rotor.BaseRotor fastRotor;
        private EnigmaSim.Components.Rotor.BaseRotor middleRotor;
        private EnigmaSim.Components.Rotor.BaseRotor slowRotor;
        private EnigmaSim.Components.Reflector.BaseReflector reflector;
        
        public Basic3Wheel(string fastRotorName, string middleRotorName, string slowRotorName, string reflectorName)
        {
            EnigmaSim.Components.Rotor.StandardRotorCollection availableRotors = new Components.Rotor.StandardRotorCollection();
            this.fastRotor = availableRotors[fastRotorName];
            this.middleRotor = availableRotors[middleRotorName];
            this.slowRotor = availableRotors[slowRotorName];
            this.reflector = new Components.Reflector.ReflectorCollection()[reflectorName];
        }

        #region IEnigma Members

        char Model.IEnigma.DecipherCharacter(char input)
        {
            char result = '\0';
            if (fastRotor.IsStep)
            {
                if (middleRotor.IsStep)
                {
                    slowRotor.Rotate();
                }
                middleRotor.Rotate();
            }
            fastRotor.Rotate();
            fastRotor.DecodeChar(input.ToEnigmaPos(), Components.Rotor.DecodeDirection.Normal);
            middleRotor.DecodeChar(fastRotor.DecodedPos, Components.Rotor.DecodeDirection.Normal);
            slowRotor.DecodeChar(middleRotor.DecodedPos, Components.Rotor.DecodeDirection.Normal);
            result = reflector[slowRotor.DecodedPos.FromEnigmaPos()];
            slowRotor.DecodeChar(result.ToEnigmaPos(), Components.Rotor.DecodeDirection.Reverse);
            middleRotor.DecodeChar(slowRotor.DecodedPos, Components.Rotor.DecodeDirection.Reverse);
            fastRotor.DecodeChar(middleRotor.DecodedPos, Components.Rotor.DecodeDirection.Reverse);
            result = fastRotor.DecodedPos.FromEnigmaPos();
            return result;
        }

        ICollection<Components.Rotor.BaseRotor> Model.IEnigma.Rotors
        {
            get
            {
                return new Components.Rotor.BaseRotorCollection(fastRotor, middleRotor, slowRotor);
            }
        }

        string Model.IEnigma.DecipherString(string input)
        {
            string result = "";
            foreach (char ch in input)
            {
                if ((ch >= 'A') && (ch <= 'Z'))
                {
                    result += (this as Model.IEnigma).DecipherCharacter(ch);
                }
                else  
                {
                    result += ch;
                }
            }
            return result;
        }
        
        #endregion

    }
}
