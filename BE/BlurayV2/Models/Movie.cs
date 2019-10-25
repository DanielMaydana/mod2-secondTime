using System;

namespace Models
{
    public class Movie
    {
        public string Name { get; private set; }
        public uint Year { get; private set; }
        public string Director { get; private set; }

        public Movie(string name, uint year, string director)
        {
            this.Name = name.Trim();
            this.Year = year;
            this.Director = director.Trim();
        }

        public static bool operator ==(Movie movieA, Movie movieB)
        {
            if (object.ReferenceEquals(movieA, movieB))
            {
                return true;
            }

            if (object.ReferenceEquals(null, movieA))
            {
                return false;
            }

            return movieA.Equals(movieB);
        }

        public static bool operator !=(Movie movieA, Movie movieB)
        {
            return !(movieA == movieB);
        }

        public override bool Equals(object value)
        {
            Movie toCompare = value as Movie;

            return !object.ReferenceEquals(null, toCompare)
                && string.Equals(this.Name, toCompare.Name)
                && uint.Equals(this.Year, toCompare.Year)
                && string.Equals(this.Director, toCompare.Director);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;
                int hash = HashingBase;

                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.Name) ? this.Name.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.Year) ? this.Year.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.Director) ? this.Director.GetHashCode() : 0);

                return hash;
            }
        }
    }
}
