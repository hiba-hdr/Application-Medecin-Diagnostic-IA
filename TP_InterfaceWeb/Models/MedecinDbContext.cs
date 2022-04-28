using Microsoft.EntityFrameworkCore;

namespace TP_InterfaceWeb.Models
{
    public class MedecinDbContext : DbContext
    {
        //Commentaire
        public MedecinDbContext()
        {
        }

        public MedecinDbContext(DbContextOptions<MedecinDbContext> options)
            : base(options)
        {
        }
        //Commentaire

        
        public DbSet<NewAccount> NewAccounts { get; set; }
        public DbSet<AjoutPatient> AjoutPatients { get; set; }
        public DbSet<Diagnostic> Diagnostics { get; set; }

        //commentaire
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        //commentaire


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string connexionString = "" +
                "server=localhost;" +
                "port=3306;" +
                "database=medecin_db;" +
                "user=medecin_user;" +
                "password=medecin_user;";
            dbContextOptionsBuilder.UseMySql(connexionString, ServerVersion.AutoDetect(connexionString));

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewAccount>(entity =>
            {
                entity.Property(e => e.Nom)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.AccountId });

                entity.ToTable("Account_Role");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Role_Account");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Role_Role");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }


    }
}
