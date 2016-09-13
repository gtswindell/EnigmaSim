using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTSoft.EnigmaSim.Components.Reflector
{
    public class BaseReflector
    {
        private Dictionary<char, char> characterMap = new Dictionary<char, char>();
        private string reflectorName;
        public BaseReflector(string name, params string[] keys)
        {
            this.reflectorName = name;
            foreach(string key in keys) 
            {
                characterMap.Add(key[0], key[1]);
                characterMap.Add(key[1], key[0]);
            }
        }

        public string Name
        {
            get
            {
                return reflectorName;
            }
        }

        public char this[char index]
        {
            get
            {
                return characterMap[index];
            }
        }
    }
}
