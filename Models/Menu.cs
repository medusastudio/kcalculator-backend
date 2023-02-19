namespace Kcalculator.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Price>? Prices { get; set; }
    }
}