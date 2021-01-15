namespace Shadowrun3
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Shadowrun3Context : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Shadowrun3.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Shadowrun3Context()
            : base("name=Shadowrun3Context")
        {
            //Database.SetInitializer<Shadowrun3Context>(new CreateDatabaseIfNotExists<Shadowrun3Context>());
            //Database.SetInitializer<Shadowrun3Context>(new DropCreateDatabaseIfModelChanges<Shadowrun3Context>());
            Database.SetInitializer<Shadowrun3Context>(new DropCreateDatabaseAlways<Shadowrun3Context>());
            //Database.SetInitializer<Shadowrun3Context>(new Shadowrun3Initializer());

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Shadowrun3Context, Shadowrun3.Migrations.Configuration>());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<EnemyMatrixProgram> EnemyMatrixPrograms { get; set; }
        public DbSet<EnemySkill> EnemySkills { get; set; }
        public DbSet<EnemySkillGroup> EnemySkillGroups { get; set; }
        public DbSet<EnemyType> EnemyTypes { get; set; }
        public DbSet<MatrixProgram> MatrixPrograms { get; set; }
        public DbSet<MeleeWeapon> MeleeWeapons { get; set; }
        public DbSet<NamedEnemy> NamedEnemys { get; set; }
        public DbSet<RangedWeapon> RangedWeapons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillGroup> SkillGroups { get; set; }
        public DbSet<Spell> Spells { get; set; }

    }
}