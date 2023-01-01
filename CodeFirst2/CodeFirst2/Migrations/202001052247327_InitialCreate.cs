namespace CodeFirst2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.menulers",
                c => new
                    {
                        SANATCIID = c.Int(nullable: false, identity: true),
                        AD = c.String(),
                        SOYAD = c.String(),
                        UCRET = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SANATCIID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.menulers");
        }
    }
}
