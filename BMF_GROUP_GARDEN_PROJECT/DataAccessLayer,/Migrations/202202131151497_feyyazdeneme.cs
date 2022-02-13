namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feyyazdeneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FeyyazDeneme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "FeyyazDeneme");
        }
    }
}
