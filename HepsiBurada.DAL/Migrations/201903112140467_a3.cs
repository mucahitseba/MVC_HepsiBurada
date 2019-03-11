namespace HepsiBurada.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bilgisayar", "NotebookResim1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Bilgisayar", "NotebookResim2", c => c.String(maxLength: 100));
            AlterColumn("dbo.Bilgisayar", "NotebookResim3", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bilgisayar", "NotebookResim3", c => c.String());
            AlterColumn("dbo.Bilgisayar", "NotebookResim2", c => c.String());
            AlterColumn("dbo.Bilgisayar", "NotebookResim1", c => c.String());
        }
    }
}
