using Microsoft.EntityFrameworkCore;

namespace BeneficialOwnerSafa.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSets
        public DbSet<BeneficialOwner> BeneficialOwners { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Nonprofit> Nonprofits { get; set; }
        public DbSet<NonprofitsUser> NonprofitsUsers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusList> StatusLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BeneficialOwner ←→ Beneficiary
            modelBuilder.Entity<BeneficialOwner>()
                .ToTable("beneficial_owners")
                .HasMany(b => b.Beneficiaries)
                .WithOne(x => x.BeneficialOwner)
                .HasForeignKey(x => x.BeneficialOwnerId);

            modelBuilder.Entity<Beneficiary>()
                .ToTable("beneficial_owner_beneficiaries");

            // BeneficialOwner ←→ Nonprofit
            modelBuilder.Entity<Nonprofit>()
                .ToTable("nonprofits")
                .HasMany(n => n.BeneficialOwners)
                .WithOne(o => o.Nonprofit)
                .HasForeignKey(o => o.NonprofitId);

            // BeneficialOwner ←→ NonprofitsUser
            modelBuilder.Entity<NonprofitsUser>()
                .ToTable("nonprofits_users")
                .HasMany(u => u.BeneficialOwners)
                .WithOne(o => o.NonprofitsUser)
                .HasForeignKey(o => o.UserId);

            // Status ←→ StatusList
            modelBuilder.Entity<Status>()
                .ToTable("status")
                .HasMany(s => s.StatusLists)
                .WithOne(l => l.Status)
                .HasForeignKey(l => l.StatusId);

            // StatusList ←→ BeneficialOwners
            modelBuilder.Entity<StatusList>()
                .ToTable("status_list")
                .HasMany(sl => sl.BeneficialOwners)
                .WithOne(o => o.StatusList)
                .HasForeignKey(o => o.StatusId);
        }
    }
}
