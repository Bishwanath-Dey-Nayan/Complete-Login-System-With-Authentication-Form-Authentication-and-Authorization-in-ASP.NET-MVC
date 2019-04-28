namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedval1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoomCategories", "CategoryName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoomCategories", "CategoryName", c => c.String());
        }
    }
}
