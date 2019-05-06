using BeerProduction.DAL.Migrations;
using BeerProduction.DAL.Models;

namespace BeerProduction.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<BatchReport> BatchReports { get; set; }
        public DbSet<StopReason> StopReasons { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }
        public DbSet<Humidity> Humidities { get; set; }
        public DbSet<MachineSpeed> MachineSpeeds { get; set; }

        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BeerProduction.DAL.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Context() : base("Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }

        public static Context Create()
        {
            return new Context();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}