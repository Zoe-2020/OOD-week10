namespace week10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addHomeGround : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "HomeGround", c => c.String());
            DropColumn("dbo.Teams", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Location", c => c.String());
            DropColumn("dbo.Teams", "HomeGround");
        }
    }
}
