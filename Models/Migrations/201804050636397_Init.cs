namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BulletinD",
                c => new
                    {
                        Bulletindtsno = c.Guid(nullable: false),
                        Bulletinsno = c.Guid(nullable: false),
                        Name = c.String(),
                        Sort = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                        IsImage = c.Boolean(nullable: false),
                        Url = c.String(),
                        Alt = c.String(),
                        Href = c.String(),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Bulletindtsno)
                .ForeignKey("dbo.BulletinM", t => t.Bulletinsno, cascadeDelete: true)
                .Index(t => t.Bulletinsno);
            
            CreateTable(
                "dbo.BulletinM",
                c => new
                    {
                        Bulletinsno = c.Guid(nullable: false),
                        Name = c.String(),
                        Sort = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Bulletinsno);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        Membersno = c.Guid(nullable: false),
                        Rolesno = c.Guid(nullable: false),
                        Account = c.String(),
                        Password = c.String(),
                        re_Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Authcode = c.String(),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Membersno)
                .ForeignKey("dbo.Role", t => t.Rolesno, cascadeDelete: true)
                .Index(t => t.Rolesno);
            
            CreateTable(
                "dbo.OrderM",
                c => new
                    {
                        Ordersno = c.Guid(nullable: false),
                        Orderno = c.Guid(nullable: false),
                        Orderdate = c.DateTime(nullable: false),
                        Membersno = c.Guid(nullable: false),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Ordersno)
                .ForeignKey("dbo.Member", t => t.Membersno, cascadeDelete: true)
                .Index(t => t.Membersno);
            
            CreateTable(
                "dbo.OrderD",
                c => new
                    {
                        Orderdtsno = c.Guid(nullable: false),
                        Ordersno = c.Guid(nullable: false),
                        Productsno = c.Guid(nullable: false),
                        serno = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Orderdtsno)
                .ForeignKey("dbo.OrderM", t => t.Ordersno, cascadeDelete: true)
                .Index(t => t.Ordersno);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Productsno = c.Guid(nullable: false),
                        Name = c.String(),
                        Author = c.String(),
                        Suppsno = c.Guid(nullable: false),
                        Publish = c.DateTime(nullable: false),
                        ActualPrice = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Language = c.String(),
                        PageNumber = c.Int(nullable: false),
                        ISBN = c.String(),
                        Url = c.String(),
                        Alt = c.String(),
                        Href = c.String(),
                        Describe = c.String(),
                        Outline = c.String(),
                        Contents = c.String(),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                        orderd_Orderdtsno = c.Guid(),
                        trollerd_Trollerdtsno = c.Guid(),
                    })
                .PrimaryKey(t => t.Productsno)
                .ForeignKey("dbo.OrderD", t => t.orderd_Orderdtsno)
                .ForeignKey("dbo.Supplier", t => t.Suppsno, cascadeDelete: true)
                .ForeignKey("dbo.TrollerD", t => t.trollerd_Trollerdtsno)
                .Index(t => t.Suppsno)
                .Index(t => t.orderd_Orderdtsno)
                .Index(t => t.trollerd_Trollerdtsno);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Suppsno = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Fax = c.String(),
                        Adress = c.String(),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Suppsno);
            
            CreateTable(
                "dbo.TrollerD",
                c => new
                    {
                        Trollerdtsno = c.Guid(nullable: false),
                        Trollersno = c.Guid(nullable: false),
                        Productsno = c.Guid(nullable: false),
                        Serno = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Trollerdtsno)
                .ForeignKey("dbo.TrollerM", t => t.Trollersno, cascadeDelete: true)
                .Index(t => t.Trollersno);
            
            CreateTable(
                "dbo.TrollerM",
                c => new
                    {
                        Trollersno = c.Guid(nullable: false),
                        Trollerno = c.String(),
                        Trollerdate = c.DateTime(nullable: false),
                        Membersno = c.Guid(nullable: false),
                        IsOrder = c.Boolean(nullable: false),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Trollersno)
                .ForeignKey("dbo.Member", t => t.Membersno, cascadeDelete: true)
                .Index(t => t.Membersno);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Rolesno = c.Guid(nullable: false),
                        Name = c.String(),
                        Sort = c.Int(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                        Createdt = c.DateTime(nullable: false),
                        Modifydt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Rolesno);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Member", "Rolesno", "dbo.Role");
            DropForeignKey("dbo.TrollerD", "Trollersno", "dbo.TrollerM");
            DropForeignKey("dbo.TrollerM", "Membersno", "dbo.Member");
            DropForeignKey("dbo.Product", "trollerd_Trollerdtsno", "dbo.TrollerD");
            DropForeignKey("dbo.Product", "Suppsno", "dbo.Supplier");
            DropForeignKey("dbo.Product", "orderd_Orderdtsno", "dbo.OrderD");
            DropForeignKey("dbo.OrderD", "Ordersno", "dbo.OrderM");
            DropForeignKey("dbo.OrderM", "Membersno", "dbo.Member");
            DropForeignKey("dbo.BulletinD", "Bulletinsno", "dbo.BulletinM");
            DropIndex("dbo.TrollerM", new[] { "Membersno" });
            DropIndex("dbo.TrollerD", new[] { "Trollersno" });
            DropIndex("dbo.Product", new[] { "trollerd_Trollerdtsno" });
            DropIndex("dbo.Product", new[] { "orderd_Orderdtsno" });
            DropIndex("dbo.Product", new[] { "Suppsno" });
            DropIndex("dbo.OrderD", new[] { "Ordersno" });
            DropIndex("dbo.OrderM", new[] { "Membersno" });
            DropIndex("dbo.Member", new[] { "Rolesno" });
            DropIndex("dbo.BulletinD", new[] { "Bulletinsno" });
            DropTable("dbo.Role");
            DropTable("dbo.TrollerM");
            DropTable("dbo.TrollerD");
            DropTable("dbo.Supplier");
            DropTable("dbo.Product");
            DropTable("dbo.OrderD");
            DropTable("dbo.OrderM");
            DropTable("dbo.Member");
            DropTable("dbo.BulletinM");
            DropTable("dbo.BulletinD");
        }
    }
}
