using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTSoft.EnigmaSim.Components.Utils
{
    public static class Utils
    {
        public static IList<char> Rotate(this IList<char> listToRotate)
        {
            char temp = listToRotate[0];
            listToRotate.RemoveAt(0);
            listToRotate.Add(temp);
            return listToRotate;
        }

        public static int ToEnigmaPos(this char ch)
        {
            return (ch - 'A');// +1;
        }

        public static char FromEnigmaPos(this int pos)
        {
            return Convert.ToChar(('A' + pos)); 
        }
    }
}
