using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KP.OrderGateway.DBModel.StockOnlineContext
{
    public partial class StockContext : DbContext
    {
        public StockContext()
        {
        }

        public StockContext(DbContextOptions<StockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineSite> MachineSite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("data source=10.3.0.122;initial catalog=stockOnline ;persist security info=true;user id=sa;password=sql2000;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => e.MachineNo);

                entity.HasIndex(e => e.MachineIp)
                    .HasName("IX_Machine")
                    .IsUnique();

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsCancel)
                    .HasColumnName("is_cancel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineIp)
                    .IsRequired()
                    .HasColumnName("machine_ip")
                    .HasMaxLength(250);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<MachineSite>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(50);

                entity.Property(e => e.SiteCode)
                    .HasColumnName("site_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });
        }
    }
}
