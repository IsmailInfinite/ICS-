namespace EF_CodeFirst_Ass1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CodeFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MId = c.Int(nullable: false, identity: true),
                        Moviename = c.String(),
                        DateOfRelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
