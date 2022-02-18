namespace DataAccessLayer_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class selamınaleyküm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CITies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DISTRICTs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CITies", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Surname = c.String(maxLength: 100),
                        Sex = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Password_Reset_Code = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Photos = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rütbeler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rütbler = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SOILTYPEs",
                c => new
                    {
                        AdressTypeId = c.Int(nullable: false, identity: true),
                        Types = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdressTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DISTRICTs", "CityId", "dbo.CITies");
            DropIndex("dbo.DISTRICTs", new[] { "CityId" });
            DropTable("dbo.SOILTYPEs");
            DropTable("dbo.Rütbeler");
            DropTable("dbo.Employees");
            DropTable("dbo.DISTRICTs");
            DropTable("dbo.CITies");
        }
    }
}
