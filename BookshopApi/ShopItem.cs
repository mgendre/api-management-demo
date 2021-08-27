using System;

namespace BookshopApi
{
    public class ShopItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public DateTime Date { get; set; } = DateTime.Now;

        public float Price { get; set; }

        public string Summary { get; set; }
    }
}