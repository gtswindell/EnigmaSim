using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTSoft.EnigmaSim.Components.Rotor
{

    public class BaseRotorCollection : ICollection<BaseRotor>
    {
        
		public class BaseRotorCollectionException : Exception
		{
			public BaseRotorCollectionException(string msg)
				: base(msg)
			{
			}
		}




		private Dictionary<string, BaseRotor> rotors = new Dictionary<string, BaseRotor>();

        public BaseRotorCollection(params BaseRotor[] rotors)
        {
            foreach (BaseRotor rotor in rotors)
            {
                this.rotors.Add(rotor.Name, rotor);
            }
        }

        public BaseRotor this[string rotorName]
        {
            get
            {
                return rotors[rotorName];
            }
        }

        protected void Add(string name, BaseRotor item)
        {
            rotors.Add(name, item);
        }

        #region ICollection<BaseRotor> Members

        void ICollection<BaseRotor>.Add(BaseRotor item)
        {
            throw new BaseRotorCollectionException("The collection is read only");
        }

        void ICollection<BaseRotor>.Clear()
        {
            throw new BaseRotorCollectionException("The collection is read only");
        }

        bool ICollection<BaseRotor>.Contains(BaseRotor item)
        {
            return rotors.ContainsKey(item.Name);
        }

        void ICollection<BaseRotor>.CopyTo(BaseRotor[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<BaseRotor>.Count
        {
            get
            {
                return rotors.Count;
            }
        }

        bool ICollection<BaseRotor>.IsReadOnly
        {
            get { return true; }
        }

        bool ICollection<BaseRotor>.Remove(BaseRotor item)
        {
            throw new BaseRotorCollectionException("The collection is read only");
        }

        #endregion

        #region IEnumerable<BaseRotor> Members

        IEnumerator<BaseRotor> IEnumerable<BaseRotor>.GetEnumerator()
        {
            return rotors.Values.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return rotors.Values.GetEnumerator();
        }

        #endregion

    }
    
    public class StandardRotorCollection : BaseRotorCollection
    {

        public StandardRotorCollection()
        {
            Add("Rotor I", 
                new BaseRotor( "Rotor I", new char[] { 'E', 'K','M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' },
                    new char[] {'Q'}));
            Add("Rotor II", 
                new BaseRotor("Rotor II", new char[] { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' },
                    new char[] { 'E' }));
            Add("Rotor III", 
                new BaseRotor("Rotor III", new char[] { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' },
                    new char[] {'V'}));
            Add("Rotor IV", 
                new BaseRotor("Rotor IV", new char[] { 'E','S','O','V','P','Z','J','A','Y','Q','U','I','R','H','X','L','N','F','T','G','K','D','C','M','W','B' },
                    new char[] { 'J' }));
            Add("Rotor V", 
                new BaseRotor("Rotor V", new char[] { 'V','Z','B','R','G','I','T','Y','U','P','S','D','N','H','L','X','A','W','M','J','Q','O','F','E','C','K' },
                    new char[] { 'Z' }));
            Add("Rotor VI", 
                new BaseRotor("Rotor VI", new char[] { 'J','P','G','V','O','U','M','F','Y','Q','B','E','N','H','Z','R','D','K','A','S','X','L','I','C','T','W' },
                    new char[] { 'Z', 'M' }));
            Add("Rotor VII", 
                new BaseRotor("Rotor VII", new char[] { 'N','Z','J','H','G','R','C','X','M','Y','S','W','B','O','U','F','A','I','V','L','P','E','K','Q','D','T' },
                    new char[] { 'Z', 'M' }));
            Add("Rotor VIII", 
                new BaseRotor("Rotor VIII", new char[] { 'F','K','Q','H','T','L','X','O','C','B','J','S','P','D','Z','R','A','M','E','W','N','I','U','Y','G','V' },
                    new char[] { 'Z', 'M' }));
        }

    }

    public class FourthRotorCollection : BaseRotorCollection
    {

        public FourthRotorCollection()
        {
            Add("Beta rotor",
                new BaseRotor("Beta rotor", new char[] { 'L', 'E', 'Y', 'J', 'V', 'C', 'N', 'I', 'X', 'W', 'P', 'B', 'Q', 'M', 'D', 'R', 'T', 'A', 'K', 'Z', 'G', 'F', 'U', 'H', 'O', 'S' },
                    new char[] { }));
            Add("Gamma rotor",
                new BaseRotor("Gamma rotor", new char[] { 'F', 'S', 'O', 'K', 'A', 'N', 'U', 'E', 'R', 'H', 'M', 'B', 'T', 'I', 'Y', 'C', 'W', 'L', 'Q', 'P', 'Z', 'X', 'V', 'G', 'J', 'D' },
                    new char[] { }));
        }

    }

}
