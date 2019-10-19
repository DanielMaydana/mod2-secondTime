namespace BlueRayStoreService
{
    using BlueRayStoreBussinesLogic;
    using BlueRayStoreModel;
    using System.Collections.Generic;

    public class Store
    {
        public Store(string storeName, int itemsPerPage, string folder, string file, int premierDays)
        {
            this.Name = storeName;
            this.ItemPerPage = itemsPerPage;
            this.Folder = folder;
            this.File = file;
            this.PremiersRange = premierDays;
            this.StoreCatalog = new Catalog();
            this.StoreCatalog.ItemsByPage = this.ItemPerPage;
            this.StoreCatalog.PremierRange = this.PremiersRange;
            this.StoreCatalog.FilePath = this.File;
            this.StoreCatalog.Folder = this.Folder;
        }

        public Store(Catalog catalog)
        {
            this.StoreCatalog = catalog;
        }

        public Catalog StoreCatalog { get; set; }

        public string Name { get; set; }

        public int ItemPerPage { get; set; }

        public string File { get; set; }

        public string Folder { get; set; }

        public int PremiersRange { get; set; }


        public List<Page> ShowCatalog()
        {
            return this.StoreCatalog.GetMovieCatalog();
        }

        public List<Page> ShowPremier()
        {
            return this.StoreCatalog.GetPremierCatalog();
        }

        public bool ImportMovies()
        {
            this.CreateDirectory();
            this.StoreCatalog.SetMovieList();
            return true;
        }

        private void CreateDirectory()
        {
            string root = $@"{this.Folder}";

            if (!System.IO.Directory.Exists(root))
            {
                System.IO.Directory.CreateDirectory(root);
            }
        }
    }
}
