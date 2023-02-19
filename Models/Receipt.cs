namespace Kcalculator.Models
{
    public class Receipt
    {
        public int ID { get; set; }
        public ICollection<Price>? Prices { get; set; }
    }
}