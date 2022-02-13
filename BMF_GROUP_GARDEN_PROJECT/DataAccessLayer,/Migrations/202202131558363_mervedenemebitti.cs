namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mervedenemebitti : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Merve");
            DropColumn("dbo.Employees", "Berkay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Berkay", c => c.String());
            AddColumn("dbo.Employees", "Merve", c => c.String());
        }
    }
}
