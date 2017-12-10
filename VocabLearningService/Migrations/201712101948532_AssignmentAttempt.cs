namespace VocabLearningService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignmentAttempt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentExercises", "Attempt", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentExercises", "Attempt");
        }
    }
}
