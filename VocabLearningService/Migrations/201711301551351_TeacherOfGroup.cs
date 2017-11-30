namespace VocabLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherOfGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentGroups", "Teacher_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.StudentGroups", "Teacher_Id");
            AddForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentGroups", "Teacher_Id", "dbo.Users");
            DropIndex("dbo.StudentGroups", new[] { "Teacher_Id" });
            DropColumn("dbo.StudentGroups", "Teacher_Id");
        }
    }
}
