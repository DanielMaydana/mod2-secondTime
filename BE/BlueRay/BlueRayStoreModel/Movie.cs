namespace BlueRayStoreModel
{
    using System;
    using System.Collections.Generic;
    using BlueRayStoreModel.Interface;

    public class Movie : IItem
    {
        public int Id { get; set; }

        public string NameMovie { get; set; }

        public List<string> Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime UploadDate { get; set; }

        public override bool Equals(object obj)
        {
            Movie movie = obj as Movie;
            return (this.NameMovie == movie.NameMovie && this.Genre == movie.Genre && this.ReleaseDate == movie.ReleaseDate);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}