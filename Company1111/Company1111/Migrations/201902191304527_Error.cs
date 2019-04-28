namespace Company1111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Error : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffRegistrationVMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EmailID = c.String(nullable: false),
                        Image = c.String(),
                        Address = c.String(nullable: false),
                        NID = c.String(nullable: false),
                        DrivingLicense = c.String(),
                        Passport = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        UserTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StaffRegistrationVMs");
        }
    }
}
