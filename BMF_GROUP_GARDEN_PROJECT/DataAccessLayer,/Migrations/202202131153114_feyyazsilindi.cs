namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class feyyazsilindi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "FeyyazDeneme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "FeyyazDeneme", c => c.String());
        }
    }
}
