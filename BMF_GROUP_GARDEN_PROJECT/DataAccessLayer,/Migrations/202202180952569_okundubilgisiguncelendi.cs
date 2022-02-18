namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class okundubilgisiguncelendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MessageTables", "okundu_bilgisi", c => c.Boolean(nullable: false));
            AlterColumn("dbo.MessageTables", "Başlık", c => c.String());
            AlterColumn("dbo.MessageTables", "İçerik", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MessageTables", "İçerik", c => c.Int(nullable: false));
            AlterColumn("dbo.MessageTables", "Başlık", c => c.Int(nullable: false));
            DropColumn("dbo.MessageTables", "okundu_bilgisi");
        }
    }
}
