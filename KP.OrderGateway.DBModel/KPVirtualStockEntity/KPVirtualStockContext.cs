using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class KPVirtualStockContext : DbContext
    {
        public KPVirtualStockContext()
        {
        }

        public KPVirtualStockContext(DbContextOptions<KPVirtualStockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VstArticleAttribute> VstArticleAttribute { get; set; }
        public virtual DbSet<VstArticleDutyPaidRemain> VstArticleDutyPaidRemain { get; set; }
        public virtual DbSet<VstArticleRemain> VstArticleRemain { get; set; }
        public virtual DbSet<VstArticleRemainHistory> VstArticleRemainHistory { get; set; }
        public virtual DbSet<VstArticleSession> VstArticleSession { get; set; }
        public virtual DbSet<VstArticleTransection> VstArticleTransection { get; set; }
        public virtual DbSet<VstConfig> VstConfig { get; set; }
        public virtual DbSet<VstLogInterface> VstLogInterface { get; set; }
        public virtual DbSet<VstMastAttibuteGroup> VstMastAttibuteGroup { get; set; }
        public virtual DbSet<VstRemainAll> VstRemainAlls { get; set; }

        // Unable to generate entity type for table 'dbo.VST_Mast_Movement'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer("Server=10.3.0.56;Database=KPVirtualStock;User Id=sa;Password=sql2000;");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<VstArticleAttribute>(entity =>
            {
                entity.ToTable("VST_Article_Attribute");

                entity.HasIndex(e => new { e.ArticleCode, e.AttrName })
                    .HasName("IX_VST_Article_Attribute");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasColumnName("article_code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AttrGroup)
                    .IsRequired()
                    .HasColumnName("attr_group")
                    .HasMaxLength(50);

                entity.Property(e => e.AttrName)
                    .IsRequired()
                    .HasColumnName("attr_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AttrValue)
                    .IsRequired()
                    .HasColumnName("attr_value");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VstArticleDutyPaidRemain>(entity =>
            {
                entity.ToTable("VST_Article_Duty_Paid_Remain");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasColumnName("article_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticleCodeDutyPaid)
                    .IsRequired()
                    .HasColumnName("article_code_duty_paid")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VstArticleRemain>(entity =>
            {
                entity.ToTable("VST_Article_Remain");

                entity.HasIndex(e => new { e.ArticleCode, e.StoreSite })
                    .HasName("IX_VST_Article_Remain");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasColumnName("article_code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RemainQty)
                    .HasColumnName("remain_qty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoreLocation)
                    .HasColumnName("store_location")
                    .HasMaxLength(50);

                entity.Property(e => e.StoreSite)
                    .IsRequired()
                    .HasColumnName("store_site")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VstArticleRemainHistory>(entity =>
            {
                entity.ToTable("VST_Article_Remain_History");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasColumnName("article_code")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date");

                entity.Property(e => e.RemainQty)
                    .HasColumnName("remain_qty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoreLocation)
                    .IsRequired()
                    .HasColumnName("store_location")
                    .HasMaxLength(50);

                entity.Property(e => e.StoreSite)
                    .IsRequired()
                    .HasColumnName("store_site")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VstArticleSession>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("VST_Article_Session");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SessionKey)
                    .IsRequired()
                    .HasColumnName("session_key");

                entity.Property(e => e.SessionRef).HasColumnName("session_ref");

                entity.Property(e => e.SessionStatus)
                    .IsRequired()
                    .HasColumnName("session_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VstArticleTransection>(entity =>
            {
                entity.HasKey(e => e.TransectionId);

                entity.ToTable("VST_Article_Transection");

                entity.HasIndex(e => new { e.SessionId, e.ArticleCode })
                    .HasName("IX_VST_Article_Transection");

                entity.Property(e => e.TransectionId).HasColumnName("transection_id");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasColumnName("article_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeductRemain)
                    .HasColumnName("isDeductRemain")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Movement)
                    .HasColumnName("movement")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.UseQty)
                    .HasColumnName("use_qty")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<VstRemainAll>(entity =>
                {

                    entity.HasKey(e => e.id);

                    entity.ToTable("VST_Aritcle_Remain_All");

                    entity.Property(e => e.id).HasColumnName("id");

                    entity.Property(e => e.article_code).HasColumnName("article_code");

                    entity.Property(e => e.site).HasColumnName("site");

                    entity.Property(e => e.location).HasColumnName("location");

                    entity.Property(e => e.qty).HasColumnName("qty");

                    entity.Property(e => e.date).HasColumnName("date");
            });

            modelBuilder.Entity<VstConfig>(entity =>
            {
                entity.ToTable("VST_Config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConfigGroup)
                    .HasColumnName("config_group")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfigKey)
                    .IsRequired()
                    .HasColumnName("config_key")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasColumnName("config_value");
            });

            modelBuilder.Entity<VstLogInterface>(entity =>
            {
                entity.HasKey(e => e.LogInterfId);

                entity.ToTable("VST_Log_Interface");

                entity.Property(e => e.LogInterfId).HasColumnName("log_interf_id");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(50);

                entity.Property(e => e.LogInterfDt)
                    .HasColumnName("log_interf_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogInterfStatus)
                    .HasColumnName("log_interf_status")
                    .HasMaxLength(50);

                entity.Property(e => e.LogInterfStatusDesc).HasColumnName("log_interf_status_desc");

                entity.Property(e => e.LogInterfType)
                    .HasColumnName("log_interf_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentLogInterfId).HasColumnName("parent_log_interf_id");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<VstMastAttibuteGroup>(entity =>
            {
                entity.ToTable("VST_Mast_Attibute_Group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttrCode)
                    .IsRequired()
                    .HasColumnName("attr_code")
                    .HasMaxLength(50);

                entity.Property(e => e.AttrGroupCode)
                    .IsRequired()
                    .HasColumnName("attr_group_code")
                    .HasMaxLength(50);
            });
        }
    }
}
