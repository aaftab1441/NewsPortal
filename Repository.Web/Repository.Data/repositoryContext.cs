using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Repository.Domain.Models.Mapping;
using Repository.Domain.Models;

namespace Repository.Data
{
    public partial class repositoryContext : DbContext
    {
        static repositoryContext()
        {
            Database.SetInitializer<repositoryContext>(null);
        }

        public repositoryContext()
            : base("Name=repositoryContext")
        {
        }

        public DbSet<login> logins { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<news> news { get; set; }
        public DbSet<newshistory> newshistories { get; set; }
        public DbSet<newsstatushistory> newsstatushistories { get; set; }
        public DbSet<newsview> newsviews { get; set; }
        public DbSet<newsvote> newsvotes { get; set; }
        public DbSet<rewardpoint> rewardpoints { get; set; }
        public DbSet<rewardpointsetting> rewardpointsettings { get; set; }
        public DbSet<tvstream> tvstreams { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<uservote> uservotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new loginMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new newsMap());
            modelBuilder.Configurations.Add(new newshistoryMap());
            modelBuilder.Configurations.Add(new newsstatushistoryMap());
            modelBuilder.Configurations.Add(new newsviewMap());
            modelBuilder.Configurations.Add(new newsvoteMap());
            modelBuilder.Configurations.Add(new rewardpointMap());
            modelBuilder.Configurations.Add(new rewardpointsettingMap());
            modelBuilder.Configurations.Add(new tvstreamMap());
            modelBuilder.Configurations.Add(new userMap());
            modelBuilder.Configurations.Add(new uservoteMap());
        }
    }
}
