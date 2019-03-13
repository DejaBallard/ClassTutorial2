using System;
using System.Collections.Generic;

namespace Version_2_C
{
    [Serializable]
    sealed class clsNameComparer : IComparer<clsWork>
    {
        private clsNameComparer() { }
        public static readonly clsNameComparer Instance = new clsNameComparer();
        public int Compare(clsWork x, clsWork y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
