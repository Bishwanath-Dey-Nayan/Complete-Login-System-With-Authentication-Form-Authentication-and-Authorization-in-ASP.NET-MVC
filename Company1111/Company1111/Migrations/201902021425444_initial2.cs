namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.Users", "GenderId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Image", c => c.String());
            AddColumn("dbo.Users", "NID", c => c.String());
            AddColumn("dbo.Users", "DrivingLicense", c => c.String());
            AddColumn("dbo.Users", "Passport", c => c.String());
            AddColumn("dbo.Users", "EmailVerification", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "SmsVerification", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "GenderId");
            CreateIndex("dbo.Users", "RoleId");
            AddForeignKey("dbo.Users", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "GenderId", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "GenderId" });
            DropColumn("dbo.Users", "RoleId");
            DropColumn("dbo.Users", "SmsVerification");
            DropColumn("dbo.Users", "EmailVerification");
            DropColumn("dbo.Users", "Passport");
            DropColumn("dbo.Users", "DrivingLicense");
            DropColumn("dbo.Users", "NID");
            DropColumn("dbo.Users", "Image");
            DropColumn("dbo.Users", "DOB");
            DropColumn("dbo.Users", "GenderId");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Email");
            DropTable("dbo.Roles");
            DropTable("dbo.Genders");
        }
    }
}
