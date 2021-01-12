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

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<SkillGroup> SkillGroups { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}