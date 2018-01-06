namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.About",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        Decriptions = c.String(maxLength: 500),
                        Image = c.String(maxLength: 250),
                        Detail = c.String(storeType: "ntext"),
                        MetaDescription = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        ParentID = c.Long(),
                        DisplayOrder = c.Int(),
                        SeoTitle = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        ShowOnHome = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(storeType: "ntext"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Content",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        Decriptions = c.String(maxLength: 500),
                        Image = c.String(maxLength: 250),
                        CategoryID = c.Long(),
                        Detail = c.String(storeType: "ntext"),
                        Warranty = c.Int(),
                        MetaDescription = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        TopHot = c.DateTime(),
                        ViewCount = c.String(maxLength: 10),
                        Tags = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ContentTag",
                c => new
                    {
                        ContentID = c.Long(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ContentID, t.TagID });
            
            CreateTable(
                "dbo.FeedBack",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 250),
                        Address = c.String(maxLength: 250),
                        Content = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footer",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(storeType: "ntext"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 50),
                        Link = c.String(maxLength: 250),
                        DisplayOrder = c.Int(),
                        Target = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        TypeID = c.Int(),
                        ParentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductCategory",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        ParentID = c.Long(),
                        DisplayOrder = c.Int(),
                        SeoTitle = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        ShowOnHome = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Code = c.String(maxLength: 10),
                        MetaTitle = c.String(maxLength: 250),
                        Decriptions = c.String(maxLength: 500),
                        Image = c.String(maxLength: 250),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Decimal(precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        CategoryID = c.Long(),
                        Detail = c.String(storeType: "ntext"),
                        Warranty = c.Int(),
                        MetaDescription = c.String(maxLength: 250),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                        TopHot = c.DateTime(),
                        ViewCount = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Slide",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(maxLength: 250),
                        DisplayOrder = c.Int(),
                        Link = c.String(maxLength: 250),
                        Desciption = c.String(maxLength: 50),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tag");
            DropTable("dbo.Slide");
            DropTable("dbo.Product");
            DropTable("dbo.ProductCategory");
            DropTable("dbo.MenuType");
            DropTable("dbo.Menu");
            DropTable("dbo.Footer");
            DropTable("dbo.FeedBack");
            DropTable("dbo.ContentTag");
            DropTable("dbo.Content");
            DropTable("dbo.Contact");
            DropTable("dbo.Category");
            DropTable("dbo.About");
        }
    }
}
