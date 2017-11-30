namespace VocabLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentsInGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "StudentGroup_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Users", "StudentGroup_Id");
            AddForeignKey("dbo.Users", "StudentGroup_Id", "dbo.StudentGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "StudentGroup_Id", "dbo.StudentGroups");
            DropIndex("dbo.Users", new[] { "StudentGroup_Id" });
            DropColumn("dbo.Users", "StudentGroup_Id");
        }
    }
}
