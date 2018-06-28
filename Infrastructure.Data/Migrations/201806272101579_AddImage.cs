namespace Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Image");
        }
    }
}
