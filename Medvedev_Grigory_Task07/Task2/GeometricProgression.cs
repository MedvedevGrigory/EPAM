using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GeometricProgression : ISeries
    {
        double start, multiplier;
        int currentIndex;

        public GeometricProgression(double start, double multiplier)
        {
            this.start = start;
            this.multiplier = multiplier;
            currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(multiplier, currentIndex - 1);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
