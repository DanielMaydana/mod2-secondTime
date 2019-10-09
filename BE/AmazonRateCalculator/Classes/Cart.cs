using System.Collections.Generic;

namespace Model
{
    public class Cart
    {
        public List<Product> productList { get; set; }

        public Cart()
        {
            this.productList = new List<Product>();
        }
    }
}
