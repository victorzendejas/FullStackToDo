namespace FullStackToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        ToDoID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todoes");
        }
    }
}
