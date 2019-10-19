namespace BlueRayStoreBussinesLogic
{
    using BlueRayStoreModel;
    using System.Collections.Generic;

    public class Store
    {
        public Store()
        {
            this.Configurations = new ConfigurationsData();
            this.Name = this.Configurations.GetValueByKey("StoreName");
            this.StoreCatalog = new Catalog();
            this.CreateDirectory();
        }

        public Store(Catalog catalog)
        {
            this.StoreCatalog = catalog;
        }

        public Store(ConfigurationsData configs, Catalog catalog)
        {
            this.Configurations = configs;
            this.Name = this.Configurations.GetValueByKey("StoreName");
            this.StoreCatalog = catalog;
            CreateDirectory();
        }

        public Catalog StoreCatalog { get; private set; }

        public string Name { get; private set; }

        private ConfigurationsData Configurations { get; set; }

        public List<Page> ShowCatalog()
        {
            return this.StoreCatalog.GetMovieCatalog();
        }

        public List<Page> ShowPremier()
        {
            return this.StoreCatalog.GetPremierCatalog();
        }

        public string GetStoreName()
        {
            return this.Name;
        }

        public bool ImportMovies()
        {
            this.StoreCatalog.SetMovieList();
            return true;
        }

        private void CreateDirectory()
        {
            string configFolder = this.Configurations.GetValueByKey("CsvFolder");
            string configFile = this.Configurations.GetValueByKey("CsvFile");
            string root = $@"{configFolder}";

            if (!System.IO.Directory.Exists(root))
            {
                System.IO.Directory.CreateDirectory(root);
            }
        }
    }
}
