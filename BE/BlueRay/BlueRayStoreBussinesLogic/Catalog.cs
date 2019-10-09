namespace BlueRayStoreBussinesLogic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using BlueRayStoreDataAccess;
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;

    public class Catalog
    {
        private CatalogPage catalogPage;

        public Catalog()
        {
            this.catalogPage = new CatalogPage();
            this.MovieList = new List<IItem>();
        }

        public Catalog(CatalogPage catalogPage)
        {
            this.catalogPage = catalogPage;
        }

        public List<IItem> MovieList { get; set; }

        public int ItemsByPage { get; set; }

        public int PremierRange { get; set; }

        public string FilePath { get; set; }

        public string Folder { get; set; }

        public List<Page> GetMovieCatalog()
        {
            List<IItem> list = new List<IItem>();
            foreach (var itemList in this.MovieList)
            {
                list.Add(itemList);
            }
            return BuildCatalog(list);
        }

        public int PremierDays { get; set; }

        private List<Page> BuildCatalog(List<IItem> list)
        {
            var pages = new List<Page>();

            if (list.Count == 0)
            {
                throw new ArgumentException("This Catalog does not contain any movie yet.");
            }

            int indexPage = 1;

            while (list.Count > 0)
            {
                var listPage = new List<IItem>();
                int limit = (list.Count < ItemsByPage) ? list.Count : ItemsByPage;
                
                listPage = list.GetRange(0, limit);
                pages.Add(this.catalogPage.AddMoviesToPage(listPage, indexPage, ItemsByPage));
                list.RemoveRange(0, limit);

                indexPage++;
            }

            return pages;
        }

        public List<Page> GetPremierCatalog()
        {
            List<IItem> list = new List<IItem>();
            foreach (var itemList in this.MovieList)
            {
                list.Add(itemList);
            }
            List<Movie> movieList = new List<Movie>();
            foreach (var movie in list)
            {
                movieList.Add(movie as Movie);
            }

            List<IItem> items = new List<IItem>();
            movieList.Sort((firstMovie, secondMovie) => secondMovie.ReleaseDate.CompareTo(firstMovie.ReleaseDate));
            foreach (var item in movieList)
            {
                if (DateTime.Compare(item.ReleaseDate, DateTime.Today.AddDays(-PremierRange)) > 0)
                {
                    items.Add(item);
                }
            }

            return BuildCatalog(items);
        }

        public bool SetMovieList()
        {
            string pathCsvFile = this.Folder + this.FilePath;
            if(!File.Exists($@"{pathCsvFile}"))
            {
                throw new ArgumentException("File not found! Be sure the file is in the specified folder " + pathCsvFile);
            }

            var listMoviesDB = CsvReader.GetAllData($@"{pathCsvFile}").Cast<Movie>().ToList();
            var listMoviesApp = this.MovieList.Cast<Movie>().ToList();

            foreach (var item in listMoviesDB)
            {
                if (!listMoviesApp.Any(movie => movie.NameMovie == item.NameMovie))
                {
                    listMoviesApp.Add(item);
                }
            }

            var listMoviesDBOrder = listMoviesApp.OrderBy(movie => movie.NameMovie).ToList();

            this.MovieList = listMoviesDBOrder.Cast<IItem>().ToList();

            return true;
        }

        private int ConvertData(string data)
        {
            return Convert.ToInt32(data);
        }
    }
}
