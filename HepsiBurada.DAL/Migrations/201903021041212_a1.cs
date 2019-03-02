namespace HepsiBurada.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bilgisayar", "EklenmeTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.BilgisayarYorum", "YorumTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BilgisayarYorum", "YorumTarihi");
            DropColumn("dbo.Bilgisayar", "EklenmeTarihi");
        }
    }
}
