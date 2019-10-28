using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class InventoryMovie : CatalogMovie
    {
        public uint InventoryCode { get; set; }
        public uint Quantity { get; set; }
        public InventoryMovie(string name, uint year, string director, uint catalogCode, uint inventoryCode, uint qty) : base(name, year, director, catalogCode)
        {
            this.InventoryCode = inventoryCode;
            this.Quantity = qty;
        }

        public override bool Equals(object value)
        {
            InventoryMovie toCompare = value as InventoryMovie;

            return !object.ReferenceEquals(null, toCompare)
                && base.Equals(toCompare)
                && uint.Equals(this.InventoryCode, toCompare.InventoryCode)
                && uint.Equals(this.Quantity, toCompare.Quantity);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;
                int hash = HashingBase;

                hash = base.GetHashCode();
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.InventoryCode) ? this.InventoryCode.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.Quantity) ? this.Quantity.GetHashCode() : 0);

                return hash;
            }
        }
    }
}
