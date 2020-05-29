namespace Atom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PharmacyData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdPharm = c.Int(nullable: false),
                        IdProspect = c.Int(nullable: false),
                        MedName = c.String(),
                        MedPrice = c.Int(nullable: false),
                        MedQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pharmacies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdDoctor = c.Int(nullable: false),
                        PharmName = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prospects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usage = c.String(),
                        Recommandations = c.String(),
                        Reactions = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        City = c.String(),
                        CNP = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.TbUsers");
            DropTable("dbo.Prospects");
            DropTable("dbo.Pharmacies");
            DropTable("dbo.Medicaments");
        }
    }
}
