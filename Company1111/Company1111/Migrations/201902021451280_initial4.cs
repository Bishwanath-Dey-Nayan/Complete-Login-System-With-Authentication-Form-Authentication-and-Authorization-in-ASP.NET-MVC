namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiscountName = c.String(),
                        DiscountCode = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OwnerHotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId)
                .Index(t => t.HotelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OwnerHotels", "userId", "dbo.Users");
            DropForeignKey("dbo.OwnerHotels", "HotelId", "dbo.Hotels");
            DropIndex("dbo.OwnerHotels", new[] { "HotelId" });
            DropIndex("dbo.OwnerHotels", new[] { "userId" });
            DropTable("dbo.OwnerHotels");
            DropTable("dbo.Discounts");
        }
    }
}
