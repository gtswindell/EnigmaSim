using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnigmaSim.Components.Reflector
{
    
    
    public class ReflectorCollection : ICollection<BaseReflector>
    {
        private Dictionary<string, BaseReflector> reflectors = new Dictionary<string, BaseReflector>();

        public ReflectorCollection()
        {
            reflectors.Add("reflector B", new BaseReflector( "reflector B", "AY", "BR", "CU", "DH", "EQ", "FS", "GL", "IP", "JX", "KN", "MO", "TZ", "VW" ));
            reflectors.Add("reflector C", new BaseReflector( "reflector C","AF", "BV", "CP", "DJ", "EI", "GO", "HY", "KR", "LZ", "MX", "NW", "TQ", "SU" ));
            reflectors.Add("reflector B Dunn", new BaseReflector("reflector B Dunn", "AE", "BN", "CK", "DQ", "FU", "GY", "HW", "IJ", "LO", "MP", "RX", "SZ", "TV"));
            reflectors.Add("reflector C Dunn", new BaseReflector("reflector C Dunn", "AR", "BD", "CO", "EJ", "FN", "GT", "HK", "IV", "LM", "PW", "QZ", "SX", "UY"));
        }

        public BaseReflector this[string reflectorName]
        {
            get
            {
                return reflectors[reflectorName];
            }
        }

        #region ICollection<BaseReflector> Members

        void ICollection<BaseReflector>.Add(BaseReflector item)
        {
            throw new ApplicationException("The collection is read only");
        }

        void ICollection<BaseReflector>.Clear()
        {
            throw new ApplicationException("The collection is read only");
        }

        bool ICollection<BaseReflector>.Contains(BaseReflector item)
        {
            return reflectors.ContainsKey(item.Name);
        }

        void ICollection<BaseReflector>.CopyTo(BaseReflector[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<BaseReflector>.Count
        {
            get { return reflectors.Count; }
        }

        bool ICollection<BaseReflector>.IsReadOnly
        {
            get { return true; }
        }

        bool ICollection<BaseReflector>.Remove(BaseReflector item)
        {
            throw new ApplicationException("The collection is read only");
        }

        #endregion

        #region IEnumerable<BaseReflector> Members

        IEnumerator<BaseReflector> IEnumerable<BaseReflector>.GetEnumerator()
        {
            return reflectors.Values.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return reflectors.Values.GetEnumerator();
        }

        #endregion
    }
}
