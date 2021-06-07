namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.rooms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Roomname = c.String(),
                        size = c.Int(nullable: false),
                        isavilable = c.Boolean(nullable: false),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
