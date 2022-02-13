namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mervedeneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Merve", c => c.String());
            AddColumn("dbo.Employees", "Berkay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Berkay");
            DropColumn("dbo.Employees", "Merve");
        }
    }
}
