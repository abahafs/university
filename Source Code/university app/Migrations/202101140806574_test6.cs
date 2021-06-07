namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Roomname = c.String(),
                        size = c.Int(nullable: false),
                        isavilable = c.Boolean(nullable: false),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.rooms");
        }
    }
}
