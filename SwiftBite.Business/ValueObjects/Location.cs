using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftBite.Business.ValueObjects
{
    public sealed record Location
    {
        public double X { get; }
        public double Y { get; }

        private Location(double x , double y)
        {
            X = x;
            Y = y;
        }

        public static Location At(double x, double y) => new(x, y);

        public double DistanceTo(Location other) => Math.Round(Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)), 2);


    }
}
