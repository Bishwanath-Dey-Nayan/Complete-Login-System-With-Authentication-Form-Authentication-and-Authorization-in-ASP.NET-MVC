namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newlyaddedusertable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Roles", newName: "UserTypes");
            DropForeignKey("dbo.Users", "GenderId", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "GenderId" });
            RenameColumn(table: "dbo.Users", name: "GenderId", newName: "Gender_Id");
            RenameColumn(table: "dbo.Users", name: "RoleId", newName: "UserTypeID");
            RenameIndex(table: "dbo.Users", name: "IX_RoleId", newName: "IX_UserTypeID");
            AddColumn("dbo.Users", "ConfirmPassword", c => c.String());
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "EmailID", c => c.String(nullable: false));
            AddColumn("dbo.Users", "DateOfBirth", c => c.DateTime());
            AddColumn("dbo.Users", "IsEmailVerified", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "ActivationCode", c => c.Guid(nullable: false));
            AddColumn("dbo.Users", "ResetPasswordCode", c => c.String());
            AlterColumn("dbo.Users", "Gender_Id", c => c.Int());
            AlterColumn("dbo.UserTypes", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "Gender_Id");
            AddForeignKey("dbo.Users", "Gender_Id", "dbo.Genders", "Id");
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "DOB");
            DropColumn("dbo.Users", "Image");
            DropColumn("dbo.Users", "Address");
            DropColumn("dbo.Users", "NID");
            DropColumn("dbo.Users", "DrivingLicense");
            DropColumn("dbo.Users", "Passport");
            DropColumn("dbo.Users", "EmailVerification");
            DropColumn("dbo.Users", "SmsVerification");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "SmsVerification", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "EmailVerification", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Passport", c => c.String());
            AddColumn("dbo.Users", "DrivingLicense", c => c.String());
            AddColumn("dbo.Users", "NID", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Address", c => c.String());
            AddColumn("dbo.Users", "Image", c => c.String());
            AddColumn("dbo.Users", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false));
            DropForeignKey("dbo.Users", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "Gender_Id" });
            AlterColumn("dbo.UserTypes", "Name", c => c.String());
            AlterColumn("dbo.Users", "Gender_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "ResetPasswordCode");
            DropColumn("dbo.Users", "ActivationCode");
            DropColumn("dbo.Users", "IsEmailVerified");
            DropColumn("dbo.Users", "DateOfBirth");
            DropColumn("dbo.Users", "EmailID");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.Users", "ConfirmPassword");
            RenameIndex(table: "dbo.Users", name: "IX_UserTypeID", newName: "IX_RoleId");
            RenameColumn(table: "dbo.Users", name: "UserTypeID", newName: "RoleId");
            RenameColumn(table: "dbo.Users", name: "Gender_Id", newName: "GenderId");
            CreateIndex("dbo.Users", "GenderId");
            AddForeignKey("dbo.Users", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.UserTypes", newName: "Roles");
        }
    }
}
