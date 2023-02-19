using System.Collections.Generic;

namespace Kcalculator.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public short? Calories { get; set; }
        public ICollection<Price>? Prices { get; set; }
    }
}