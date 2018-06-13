using System.Collections.Generic;

namespace Domain.Entities
{
    public class Category : BaseModel
    {
        public string CategoryName { get; set; }
        public virtual List<Item> Items { get; set; }

    }


    public class Vendor : BaseModel
    {
        public string VendorName { get; set; }
        public virtual List<Item> Items { get; set; }
        public List<Category> Categories { get; set; }
    }

    public class Item : BaseModel
    {
        public Category Category { get; set; }
        public Vendor Vendor { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class BaseModel
    {
        public int ID { get; set; }
        
    }

}


