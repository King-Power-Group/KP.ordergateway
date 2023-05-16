using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KP.OrderGateway.DBModel
{
    public partial class CustomerDataContext : DbContext
    {
        public CustomerDataContext()
        {
        }

        public CustomerDataContext(DbContextOptions<CustomerDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DbConnection> DbConnection { get; set; }
        public virtual DbSet<ShipTrans> CUSD_ShippingTrans { get; set; }
        public virtual DbSet<SubBranch> CONS_SubBranch { get; set; }
        public virtual DbSet<DtServer> DtServers { get; set; }
        public virtual DbSet<Config> CUSD_Config { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=10.3.0.51;initial catalog =CustomerData;persist security info=true;user id=sa;password=sql2000;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasKey(e => e.ConfigKey);
                entity.Property(e => e.ConfigCode).HasColumnName("ConfigCode")
                   .HasMaxLength(200);

                entity.Property(e => e.ConfigData).HasColumnName("ConfigData")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<SubBranch>(entity =>
            {
                entity.HasKey(e => e.subBranchCode);
                entity.ToTable("CONS_SubBranch");
                entity.Property(e => e.branchNo).HasColumnName("BranchNo")
                   .HasMaxLength(200);

                entity.Property(e => e.subBranchCode).HasColumnName("SubBranchCode")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.subBranchName).HasColumnName("SubBranchName")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.isCancel).HasColumnName("IsCanceled");
  
            });

            modelBuilder.Entity<ShipTrans>(entity =>
            {
                entity.HasKey(e => e.transID);

                entity.ToTable("CUSD_ShippingTrans");

                entity.Property(e => e.transID).HasColumnName("shipTransId").ValueGeneratedOnAdd();

                entity.Property(e => e.transSessionID).HasColumnName("shipTransSessionID")
                    .IsRequired()
                    .IsUnicode(false)
                    .HasMaxLength(200);


                entity.Property(e => e.transSessionValue).HasColumnName("shipTransValue")
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

            });

            modelBuilder.Entity<DbConnection>(entity =>
            {
                entity.HasKey(e => e.ConCode);

                entity.ToTable("DB_Connection");

                entity.Property(e => e.ConCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DbBranch)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DbName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DbPass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DbServer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DbType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DbUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
