namespace Infrastructure.Data.Migrations
{
    using Domain.Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MarryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MarryDBContext context)
        {
            var item1 = new Item
            {
                ItemName = "Gucci",
                Price = 30000,
                Description = "A two buttton suit, perfect for your wedding occasion.",
                ImageUrl = "~/Content/img/suit-1.jpg"
                
            };

            var item2 = new Item
            {
                ItemName = "Dolce & Gabana",
                Price = 45000,
                Description = "A two button suit, perfect for your wedding occasion.",
                ImageUrl = "~/Content/img/suit-3.jpg"

            };

            var item3 = new Item
            {
                ItemName = "Louis Vuitton",
                Price = 39000,
                Description = "A two button  suit, perfect for your wedding occasion.",
                ImageUrl = "~/Content/img/suit-6.jpg"

            };

            var item4 = new Item
            {
                ItemName = "Rhesus",
                Price = 26000,
                Description = "A silver diamond encrusted ring, forged from the uhu metals of Asgard .",
                ImageUrl = "~/Content/img/ring1.jpeg"

            };

            var item5 = new Item
            {
                ItemName = "Metallo",
                Price = 15000,
                Description = "A Gold and Silver ring with a diamond at its core.",
                ImageUrl = "~/Content/img/ring2.jpeg"

            };

            var item6 = new Item
            {
                ItemName = "Mirage",
                Price = 44000,
                Description = "Purple never felt better.",
                ImageUrl = "~/Content/img/ring3.jpeg"

            };

          

            var item7 = new Item
            {
                ItemName = "Givenchy",
                Price = 150000,
                Description = "Elegant, Graceful and  Beautiful are words that best describe this beauty",
                ImageUrl = "~/Content/img/dress3.jpg"

            };

            var item8 = new Item
            {
                ItemName = "Altrs & Beddo",
                Price = 255000,
                Description = "This effortless beauty was handcrafted by skilled professionals over the period of 150 days. Woven to perfection",
                ImageUrl = "~/Content/img/dress1.jpg"

            };

            var item9 = new Item
            {
                ItemName = "Xio Yang",
                Price = 96000,
                Description = "A Beautiful dress handed down to earthlings by Mother Gaia herself!!",
                ImageUrl = "~/Content/img/dressB.jpeg"

            };




            //Category

            var category1 = new Category
            {
                CategoryName = "Suits",
                Items = new List<Item>()
                {
                    item1,item2,item3
                }
            };

            var category2 = new Category
            {
                CategoryName = "Rings",
                Items = new List<Item>()
                {
                    item4,item5,item6
                }
            };

            var category3 = new Category
            {
                CategoryName = "Wedding Gown",
                Items = new List<Item>()
                {
                    item7,item8,item9
                }
            };


            //Vendor
            var vendor1 = new Vendor
            {
                VendorName = "Winnie Maids",
                Categories = new List<Category>()
                {
                    category1,category2,category3
                },
                Items = new List<Item>()
                {
                    item1,item2,item4,item5,item7
                }
            };

            var vendor2 = new Vendor
            {
                VendorName = "Andora",
                Categories = new List<Category>()
                {
                    category1,category2,category3
                },
                Items = new List<Item>()
                {
                    item3,item6,item8,item9
                }
            };

            //seed to DB
            context.Set<Category>().AddOrUpdate(c => c.CategoryName, category1);
            context.Set<Category>().AddOrUpdate(c => c.CategoryName, category2);
            context.Set<Category>().AddOrUpdate(c => c.CategoryName, category3);
            context.Set<Vendor>().AddOrUpdate(c => c.VendorName, vendor1);
            context.Set<Vendor>().AddOrUpdate(c => c.VendorName, vendor2);



        }



    }
}
