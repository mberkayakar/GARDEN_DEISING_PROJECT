namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Messagetableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageTables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Başlık = c.Int(nullable: false),
                        İçerik = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MessageTables");
        }
    }
}
