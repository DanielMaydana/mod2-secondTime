namespace BlueRayStoreDataAccess
{
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class CsvReader
    {
        public static List<IItem> GetAllData(string path)
        {
            List<IItem> listOfMovies = new List<IItem>();

            using (StreamReader reader = new StreamReader(File.OpenRead(path)))
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new ArgumentException("The path is null or empty.");
                }

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');

                    string name = values[0];

                    string[] genresArray = values[1].Split(' ');
                    List<string> genre = genresArray.ToList();

                    string[] releaseDateArray = values[2].Split('/');
                    var releaseDate = new DateTime(ConvertData(releaseDateArray[2]), ConvertData(releaseDateArray[1]), ConvertData(releaseDateArray[0]));

                    string[] uploadDateArray = values[3].Split('/');
                    var uploadDate = new DateTime(ConvertData(releaseDateArray[2]), ConvertData(releaseDateArray[1]), ConvertData(releaseDateArray[0]));

                    listOfMovies.Add(new Movie { NameMovie = name, Genre = genre, ReleaseDate = releaseDate, UploadDate = uploadDate });
                }

                if (listOfMovies.Count == 0)
                {
                    throw new ArgumentException("There is not data in the database.");
                }
            }

            return listOfMovies;
        }

        private static int ConvertData(string data)
        {
            return Convert.ToInt32(data);
        }
    }
}
