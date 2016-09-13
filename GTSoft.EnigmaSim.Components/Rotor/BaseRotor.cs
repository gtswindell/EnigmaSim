using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GTSoft.EnigmaSim.Components.Utils;

namespace GTSoft.EnigmaSim.Components.Rotor
{
    
    public enum DecodeDirection { Normal, Reverse };
    
    public class BaseRotor
    {
        private List<char> leftChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().ToList();
        private List<char> rightChars;
        private List<char> stepChars = new List<char>();

        
        public BaseRotor(string name, char[] chars, params int[] stepChars)
            : this(name, chars)
        {
            foreach(int ch in stepChars) 
            {
                this.stepChars.Add(Convert.ToChar(ch + 'A'));
            }
        }

        public BaseRotor(string name, char[] chars, params char[] stepChars) 
            : this(name, chars)
        {
            this.stepChars.AddRange(stepChars);
        }

        private BaseRotor(string name, char[] chars) 
        {
            rightChars = chars.ToList();
            Name = name;
        }

        public void SetWheelOffset(char startPos)
        {
            SetWheelOffset((startPos - 'A') + 1);
        }

        
        public void SetWheelOffset(int startPos)
        {
            if (startPos < 1 || startPos > 26)
                throw new ArgumentOutOfRangeException("startPos", startPos, "The startPos must be given in the range 1-26");

            for (int r = 0; r < startPos - 1; r++)
            {
                Rotate();
            }
        }
        
        public string Name { get; set; }

        public int DecodedPos { get; private set; }
        
        public void DecodeChar(int pos, DecodeDirection direction) 
        {
            if (direction == DecodeDirection.Normal)
            {
                char currentRight = rightChars.ElementAt(pos);
                DecodedPos = leftChars.IndexOf(currentRight);
            }
            else
            {
                char currentLeft = leftChars.ElementAt(pos);
                DecodedPos = rightChars.IndexOf(currentLeft);
            }
        }

        public bool IsStep
        {
            get
            {
                return stepChars.Contains(leftChars[0]);
            }
        }

        public void Rotate()
        {
            leftChars.Rotate();
            rightChars.Rotate();
        }
    }


    /*        
            private List<char> charMap = new List<char>();
            private List<char> stepPos = new List<char>();
            private string name;
            private char currentPos;
            public BaseRotor(string rotorName, char[] chars, char[] stepPos)
            {
                this.name = rotorName;
                this.charMap.AddRange(chars);
                if (stepPos != null)
                {
                    this.stepPos.AddRange(stepPos);
                }
                this.currentPos = 'A';
            }

            public void SetStartCharacter(char startPos)
            {
                currentPos = startPos;
            }

            public string Name
            {
                get
                {
                    return name;
                }
            }

            public char this[char charToMap]
            {
                get
                {
                    return charMap[charToMap-'A'];
                }
            }

            public char MapToChar(char charToMap)
            {
                return this[charToMap];
            }

            public void Rotate() 
            {
                currentPos++;
                if (currentPos > 'Z') currentPos = 'A';
            }

            public bool IsStep
            {
                get
                {
                    return stepPos.ToList<char>().Contains(currentPos);
                }
            }

        }
     */
}
