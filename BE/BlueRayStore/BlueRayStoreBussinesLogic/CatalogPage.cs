namespace BlueRayStoreBussinesLogic
{
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;
    using System.Collections.Generic;

    public class CatalogPage
    {
        public Page AddMoviesToPage(List<IItem> items, int pageNumber, int itemsByPage)
        {
            Page onePageOfCatalog = new Page { MoviePageList = items, PageNumber = pageNumber, ItemsByPage = itemsByPage };
            return onePageOfCatalog;
        }
    }
}