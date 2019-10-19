namespace BlueRayStoreModel
{
    using System;
    using System.Collections.Generic;
    using BlueRayStoreModel.Interface;

    public class Page
    {
        public Page()
        {
            this.MoviePageList = new List<IItem>();
            this.PageNumber = 0;
            this.ItemsByPage = 0;
        }

        public List<IItem> MoviePageList { get; set; }

        public int PageNumber { get; set; }

        public int ItemsByPage { get; set; }
        
        public override bool Equals(object obj)
        {
            Page page = obj as Page;
            return (this.MoviePageList == page.MoviePageList && this.PageNumber == page.PageNumber && this.ItemsByPage == page.ItemsByPage);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}