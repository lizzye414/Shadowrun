namespace Shadowrun3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SkillGroups",
                c => new
                    {
                        SkillGroupId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SkillGroupId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillId = c.String(nullable: false, maxLength: 128),
                        Attribute = c.String(),
                        SkillGroup_SkillGroupId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SkillId)
                .ForeignKey("dbo.SkillGroups", t => t.SkillGroup_SkillGroupId)
                .Index(t => t.SkillGroup_SkillGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "SkillGroup_SkillGroupId", "dbo.SkillGroups");
            DropIndex("dbo.Skills", new[] { "SkillGroup_SkillGroupId" });
            DropTable("dbo.Skills");
            DropTable("dbo.SkillGroups");
        }
    }
}
