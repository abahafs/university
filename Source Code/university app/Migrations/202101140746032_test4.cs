namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.courses", "RoomId", c => c.Int(nullable: false));
            CreateIndex("dbo.courses", "RoomId");
            AddForeignKey("dbo.courses", "RoomId", "dbo.rooms", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "RoomId", "dbo.rooms");
            DropIndex("dbo.courses", new[] { "RoomId" });
            DropColumn("dbo.courses", "RoomId");
        }
    }
}
