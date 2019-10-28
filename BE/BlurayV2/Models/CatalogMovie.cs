
namespace Models
{
    public class CatalogMovie : Movie
    {
        public uint CatalogCode { get; private set; }
        public CatalogMovie(string name, uint year, string director, uint code) : base(name, year, director)
        {
            this.CatalogCode = code;
        }

        public override bool Equals(object obj)
        {
            var toCompare = obj as CatalogMovie;

            return !object.ReferenceEquals(null, toCompare)
                && base.Equals(toCompare)
                && uint.Equals(this.CatalogCode, toCompare.CatalogCode);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;
                int hash = HashingBase;

                hash = base.GetHashCode();
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.CatalogCode) ? this.CatalogCode.GetHashCode() : 0);

                return hash;
            }
        }
    }
}
