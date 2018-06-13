namespace Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Vendor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vendors", t => t.Vendor_ID)
                .Index(t => t.Vendor_ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Category_ID = c.Int(),
                        Vendor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.Vendors", t => t.Vendor_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.Vendor_ID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VendorName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Vendor_ID", "dbo.Vendors");
            DropForeignKey("dbo.Categories", "Vendor_ID", "dbo.Vendors");
            DropForeignKey("dbo.Items", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "Vendor_ID" });
            DropIndex("dbo.Items", new[] { "Category_ID" });
            DropIndex("dbo.Categories", new[] { "Vendor_ID" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}
