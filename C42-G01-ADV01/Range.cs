using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV01
{
    #region Q02
    // 1. Create a generic class named Range<T> where T represents the type of values.
    // 5. Note: You can assume that the type T used in the Range<T> class
    // implements the IComparable<T> interface to allow for comparisons.
    internal class Range<T> where T : IComparable<T>
    {

        public T Min { get; set; }
        public T Max { get; set; }
        // 2. Implement a constructor that takes the minimum and maximum
        // values to define the range.
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }
        // 3. Implement a method IsInRange(T value) that returns true if the given
        // value is within the range, otherwise false.
        public bool IsInRange(T value)
        {
            if (value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 4. Implement a method Length() that returns the length of the range
        // (the difference between the maximum and minimum values).
        // جربت كذا حاجه ومش عارف

        #endregion

    }
}
