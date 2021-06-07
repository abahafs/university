namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mmnm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.courses", "courseID", c => c.Int(nullable: false));
            CreateIndex("dbo.courses", "courseID");
            AddForeignKey("dbo.courses", "courseID", "dbo.rooms", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "courseID", "dbo.rooms");
            DropIndex("dbo.courses", new[] { "courseID" });
            DropColumn("dbo.courses", "courseID");
        }
    }
}
