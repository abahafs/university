namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test7 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.courses", "RoomId");
            AddForeignKey("dbo.courses", "RoomId", "dbo.rooms", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "RoomId", "dbo.rooms");
            DropIndex("dbo.courses", new[] { "RoomId" });
        }
    }
}
