using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace clean_arch.Infrastructure.EntityFramework.Models;

public partial class BikeMarketContext : DbContext
{
    public BikeMarketContext()
    {
    }

    public BikeMarketContext(DbContextOptions<BikeMarketContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DieselSchemaMigration> DieselSchemaMigrations { get; set; }

    public virtual DbSet<TbItem> TbItems { get; set; }

    public virtual DbSet<TbItemType> TbItemTypes { get; set; }

    public virtual DbSet<TbRole> TbRoles { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=ep-polished-glade-22606167.eu-central-1.aws.neon.tech;Port=5432;Database=bike-market;Username=tverdohlebovartem;Password=1aYkNAxZhLO8");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DieselSchemaMigration>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("__diesel_schema_migrations_pkey");

            entity.ToTable("__diesel_schema_migrations");

            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .HasColumnName("version");
            entity.Property(e => e.RunOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("run_on");
        });

        modelBuilder.Entity<TbItem>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("tb_item_pkey");

            entity.ToTable("tb_item");

            entity.HasIndex(e => e.ItemName, "tb_item_item_name_key").IsUnique();

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemDescription).HasColumnName("item_description");
            entity.Property(e => e.ItemImage)
                .HasMaxLength(200)
                .HasColumnName("item_image");
            entity.Property(e => e.ItemName)
                .HasMaxLength(40)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemTypeId).HasColumnName("item_type_id");

            entity.HasOne(d => d.ItemType).WithMany(p => p.TbItems)
                .HasForeignKey(d => d.ItemTypeId)
                .HasConstraintName("tb_item_item_type_id_fkey");
        });

        modelBuilder.Entity<TbItemType>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("tb_item_type_pkey");

            entity.ToTable("tb_item_type");

            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.TypeName)
                .HasMaxLength(10)
                .HasColumnName("type_name");
        });

        modelBuilder.Entity<TbRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("tb_role_pkey");

            entity.ToTable("tb_role");

            entity.HasIndex(e => e.RoleName, "tb_role_role_name_key").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(30)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("tb_user_pkey");

            entity.ToTable("tb_user");

            entity.HasIndex(e => e.UserLogin, "tb_user_user_login_key").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(320)
                .HasColumnName("user_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(30)
                .HasColumnName("user_login");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .HasColumnName("user_password");
            entity.Property(e => e.UserRoleId)
                .HasDefaultValue(3)
                .HasColumnName("user_role_id");

            entity.HasOne(d => d.UserRole).WithMany(p => p.TbUsers)
                .HasForeignKey(d => d.UserRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_role_id_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
