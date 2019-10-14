namespace Model
{
    public class Item
    {
        public string Category { get; private set; }
        public int Quality { get; private set; }
        public int SellIn { get; private set; }

        public Item(string category, int quality, int remainingDays)
        {
            Category = category;
            Quality = quality;
            SellIn = remainingDays;
        }
    }
}
