namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userclassmodified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Image", c => c.String());
            AddColumn("dbo.Users", "Address", c => c.String());
            AddColumn("dbo.Users", "NID", c => c.String());
            AddColumn("dbo.Users", "DrivingLicense", c => c.String());
            AddColumn("dbo.Users", "Passport", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Passport");
            DropColumn("dbo.Users", "DrivingLicense");
            DropColumn("dbo.Users", "NID");
            DropColumn("dbo.Users", "Address");
            DropColumn("dbo.Users", "Image");
        }
    }
}
