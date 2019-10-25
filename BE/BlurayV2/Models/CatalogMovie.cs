
namespace Models
{
    public class CatalogMovie : Movie
    {
        public uint Code { get; private set; }
        public CatalogMovie(string name, uint year, string director, uint code) : base(name, year, director)
        {
            this.Code = code;
        }
    }
}
