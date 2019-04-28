namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffHotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.RoomCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Hotels", "Email", c => c.String());
            AddColumn("dbo.Hotels", "Phone", c => c.String());
            AddColumn("dbo.Hotels", "Description", c => c.String());
            AddColumn("dbo.Hotels", "ZipCode", c => c.String());
            AddColumn("dbo.Hotels", "Facilities", c => c.String());
            AddColumn("dbo.Hotels", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.Hotels", "TotalStaff", c => c.Int(nullable: false));
            AddColumn("dbo.Hotels", "TotalRoom", c => c.Int(nullable: false));
            AddColumn("dbo.Hotels", "TotalFloor", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "Image", c => c.String());
            AddColumn("dbo.Rooms", "Facilities", c => c.String());
            AddColumn("dbo.Rooms", "Description", c => c.String());
            AddColumn("dbo.Rooms", "View", c => c.String());
            AddColumn("dbo.Rooms", "Status", c => c.String());
            AddColumn("dbo.Rooms", "BedNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Rooms", "BedType", c => c.String());
            AddColumn("dbo.Rooms", "RoomCategories_Id", c => c.Int());
            CreateIndex("dbo.Rooms", "RoomCategories_Id");
            AddForeignKey("dbo.Rooms", "RoomCategories_Id", "dbo.RoomCategories", "Id");
            DropColumn("dbo.Rooms", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Name", c => c.String());
            DropForeignKey("dbo.StaffHotels", "UserId", "dbo.Users");
            DropForeignKey("dbo.StaffHotels", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Rooms", "RoomCategories_Id", "dbo.RoomCategories");
            DropIndex("dbo.Rooms", new[] { "RoomCategories_Id" });
            DropIndex("dbo.StaffHotels", new[] { "HotelId" });
            DropIndex("dbo.StaffHotels", new[] { "UserId" });
            DropColumn("dbo.Rooms", "RoomCategories_Id");
            DropColumn("dbo.Rooms", "BedType");
            DropColumn("dbo.Rooms", "BedNumber");
            DropColumn("dbo.Rooms", "Status");
            DropColumn("dbo.Rooms", "View");
            DropColumn("dbo.Rooms", "Description");
            DropColumn("dbo.Rooms", "Facilities");
            DropColumn("dbo.Rooms", "Image");
            DropColumn("dbo.Rooms", "CategoryId");
            DropColumn("dbo.Hotels", "TotalFloor");
            DropColumn("dbo.Hotels", "TotalRoom");
            DropColumn("dbo.Hotels", "TotalStaff");
            DropColumn("dbo.Hotels", "Rating");
            DropColumn("dbo.Hotels", "Facilities");
            DropColumn("dbo.Hotels", "ZipCode");
            DropColumn("dbo.Hotels", "Description");
            DropColumn("dbo.Hotels", "Phone");
            DropColumn("dbo.Hotels", "Email");
            DropTable("dbo.RoomCategories");
            DropTable("dbo.StaffHotels");
        }
    }
}
