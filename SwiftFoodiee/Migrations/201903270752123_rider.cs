namespace SwiftFoodiee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RiderProfile",
                c => new
                    {
                        RiderID = c.Long(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Phoneno = c.String(),
                    })
                .PrimaryKey(t => t.RiderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RiderProfile");
        }
    }
}
