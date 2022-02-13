namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedresetcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Password_Reset_Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Password_Reset_Code");
        }
    }
}
