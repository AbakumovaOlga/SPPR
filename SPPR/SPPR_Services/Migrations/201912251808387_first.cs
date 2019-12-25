namespace SPPR_Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarkParametrs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mark = c.Int(nullable: false),
                        Down = c.Int(nullable: false),
                        Average = c.Int(nullable: false),
                        Up = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Cheking = c.Boolean(nullable: false),
                        ParametrId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parametrs", t => t.ParametrId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ParametrId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Parametrs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Choosing = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TelepParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        TelephoneId = c.Int(nullable: false),
                        ParametrId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parametrs", t => t.ParametrId, cascadeDelete: true)
                .ForeignKey("dbo.Telephones", t => t.TelephoneId, cascadeDelete: true)
                .Index(t => t.TelephoneId)
                .Index(t => t.ParametrId);
            
            CreateTable(
                "dbo.Telephones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First = c.Int(nullable: false),
                        Second = c.Int(nullable: false),
                        Third = c.Int(nullable: false),
                        Count = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarkParametrs", "UserId", "dbo.Users");
            DropForeignKey("dbo.TelepParams", "TelephoneId", "dbo.Telephones");
            DropForeignKey("dbo.TelepParams", "ParametrId", "dbo.Parametrs");
            DropForeignKey("dbo.MarkParametrs", "ParametrId", "dbo.Parametrs");
            DropIndex("dbo.TelepParams", new[] { "ParametrId" });
            DropIndex("dbo.TelepParams", new[] { "TelephoneId" });
            DropIndex("dbo.MarkParametrs", new[] { "UserId" });
            DropIndex("dbo.MarkParametrs", new[] { "ParametrId" });
            DropTable("dbo.Trends");
            DropTable("dbo.Users");
            DropTable("dbo.Telephones");
            DropTable("dbo.TelepParams");
            DropTable("dbo.Parametrs");
            DropTable("dbo.MarkParametrs");
        }
    }
}
