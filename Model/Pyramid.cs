using System;

namespace lab2_61.Model
{
    public class Pyramid : Solid
    {
        private double a;
        private double h;

        public Pyramid(double a, double h)
        {
            this.a = a;
            this.h = h;
        }

        protected internal override double GetVolume()
        {
            return 1.0 / 3.0 * Math.Pow(a, 2) * h;
        }
    }
}