using Domain.Entities;
using System.Collections.Generic;

namespace MarryMeStore.ViewModel
{
    public class ItemViewModel
    {
        public virtual List<Item> Items { get; set; }
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}