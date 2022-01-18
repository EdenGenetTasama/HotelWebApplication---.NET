namespace HotelWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuestMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.guests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        YearOfBirth = c.Int(nullable: false),
                        CheckOut = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.guests");
        }
    }
}
