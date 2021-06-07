namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.courses", "RoomId");
            AddForeignKey("dbo.courses", "RoomId", "dbo.rooms", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "RoomId", "dbo.rooms");
            DropIndex("dbo.courses", new[] { "RoomId" });
        }
    }
}
