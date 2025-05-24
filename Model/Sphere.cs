using System;

namespace lab2_61.Model
{
    public class Sphere : ISolid
    {
        private double r;

        public Sphere(double r)
        {
            this.r = r;
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        }
    }
}