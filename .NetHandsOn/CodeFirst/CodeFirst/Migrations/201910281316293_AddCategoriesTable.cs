﻿namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Categories VALUES(1,'Web Development')");
            Sql("INSERT INTO Categories VALUES(2,'Algorithms')");
            Sql("INSERT INTO Categories VALUES(3,'Databases')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
