namespace Kcalculator.Models
{
    public class Price
    {
        public int ID { get; set; }
        public int MenuID { get; set; }
        public int ItemID { get; set; }
        public int Fee { get; set; }
        public Menu? Menu { get; set; }
        public Item? Item { get; set; }
        public ICollection<Receipt>? Receipts { get; set; }
    }
}