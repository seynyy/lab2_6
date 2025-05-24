using System;

namespace lab2_61.Model
{
    public class Pyramid : ISolid
    {
        private double a;
        private double h;

        public Pyramid(double a, double h)
        {
            this.a = a;
            this.h = h;
        }

        public double GetVolume()
        {
            return 1.0 / 3.0 * Math.Pow(a, 2) * h;
        }
    }
}