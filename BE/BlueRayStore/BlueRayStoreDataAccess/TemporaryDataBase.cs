namespace BlueRayStoreDataAccess
{
    using System;
    using System.Collections.Generic;
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;

    public class TemporaryDataBase
    {
        public TemporaryDataBase()
        {
            this.MovieList = new List<IItem>();
            this.LoadList();
        }

        public List<IItem> MovieList { get; private set; }

        public void LoadList()
        {
            this.MovieList.Add(new Movie { Id = 100, Genre = new List<string> { "Action" }, NameMovie = "Uri: The Surgical Strike", ReleaseDate = new DateTime(2018, 1, 11), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 101, Genre = new List<string> { "Action" }, NameMovie = "Battalion 609", ReleaseDate = new DateTime(2018, 1, 11), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 102, Genre = new List<string> { "Biopic" }, NameMovie = "The Accidental Prime Minister", ReleaseDate = new DateTime(2018, 1, 11), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 103, Genre = new List<string> { "Drama" }, NameMovie = "Why Cheat India", ReleaseDate = new DateTime(2019, 4, 11), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 104, Genre = new List<string> { "Comedy" }, NameMovie = "Fraud Saiyaan", ReleaseDate = new DateTime(2018, 1, 18), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 105, Genre = new List<string> { "Crime", "Drama" }, NameMovie = "Soni", ReleaseDate = new DateTime(2018, 1, 18), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 106, Genre = new List<string> { "Biographical", "Drama" }, NameMovie = "72 Hours: Martyr Who Never Died", ReleaseDate = new DateTime(2019, 4, 2), UploadDate = new DateTime(2019, 4, 2) });
            this.MovieList.Add(new Movie { Id = 107, Genre = new List<string> { "comedy" }, NameMovie = "Bombairiya", ReleaseDate = new DateTime(2019, 3, 11), UploadDate = new DateTime(2019, 4, 3) });
            this.MovieList.Add(new Movie { Id = 108, Genre = new List<string> { "Comedy" }, NameMovie = "Rangeela Raja", ReleaseDate = new DateTime(2019, 3, 18), UploadDate = new DateTime(2019, 4, 3) });
            this.MovieList.Add(new Movie { Id = 109, Genre = new List<string> { "Drama" }, NameMovie = "The Lift Boy", ReleaseDate = new DateTime(2019, 2, 18), UploadDate = new DateTime(2019, 4, 3) });
            this.MovieList.Add(new Movie { Id = 110, Genre = new List<string> { "Biographical" }, NameMovie = "Thackeray", ReleaseDate = new DateTime(2019, 1, 25), UploadDate = new DateTime(2019, 4, 3) });
        }

        public List<IItem> GetList()
        {
            return this.MovieList;
        }
    }
}
