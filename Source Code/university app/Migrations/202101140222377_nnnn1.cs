namespace university_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nnnn1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.courses", "TeachId", "dbo.teachers");
            DropIndex("dbo.courses", new[] { "TeachId" });
            AddColumn("dbo.courses", "CourseCode", c => c.String());
            AlterColumn("dbo.courses", "TeachId", c => c.Int(nullable: false));
            CreateIndex("dbo.courses", "TeachId");
            AddForeignKey("dbo.courses", "TeachId", "dbo.teachers", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "TeachId", "dbo.teachers");
            DropIndex("dbo.courses", new[] { "TeachId" });
            AlterColumn("dbo.courses", "TeachId", c => c.Int());
            DropColumn("dbo.courses", "CourseCode");
            CreateIndex("dbo.courses", "TeachId");
            AddForeignKey("dbo.courses", "TeachId", "dbo.teachers", "ID");
        }
    }
}
