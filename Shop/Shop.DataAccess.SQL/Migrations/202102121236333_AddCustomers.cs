namespace Shop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.BasketItems", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.BasketItems", "Qunatity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BasketItems", "Qunatity", c => c.Int(nullable: false));
            DropColumn("dbo.BasketItems", "Quantity");
            DropTable("dbo.Customers");
        }
    }
}
