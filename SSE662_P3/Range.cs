using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE662_P3
{
    public class Range
    {
        private int _min;
        private int _max;

        public Range(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public bool InRange(int value)
        {
            bool isLargerThanOrEqualToMin = value >= _min;
            bool isLessThanOrEqualToMax = value <= _max;

            if (isLargerThanOrEqualToMin && isLessThanOrEqualToMax)
            {
                return true;
            }

            return false;
        }

        public bool InRange(List<int> listOfValues, int valueToCheck)
        {
            _min = listOfValues.Min();
            _max = listOfValues.Max();

            return InRange(valueToCheck);
        }
    }
}
