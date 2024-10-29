using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWVApi.Data;

public partial class AdventureWvContext : DbContext
{
    public AdventureWvContext()
    {
    }

    public AdventureWvContext(DbContextOptions<AdventureWvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Hospitality> Hospitalities { get; set; }

    public virtual DbSet<Landmark> Landmarks { get; set; }

    public virtual DbSet<Travelplan> Travelplans { get; set; }

    public virtual DbSet<UserTravel> UserTravels { get; set; }

    public virtual DbSet<Userdatum> Userdata { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__ACTIVITI__C69007C8F1F72C4B");

            entity.ToTable("ACTIVITIES");

            entity.HasIndex(e => new { e.Aname, e.Lid }, "ADSD").IsUnique();

            entity.Property(e => e.Aid).HasColumnName("AID");
            entity.Property(e => e.Aname)
                .HasMaxLength(255)
                .HasColumnName("AName");
            entity.Property(e => e.Lid).HasColumnName("LID");

            entity.HasOne(d => d.LidNavigation).WithMany(p => p.Activities)
                .HasForeignKey(d => d.Lid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACTIVITIES__LID__3A81B327");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Hospitality>(entity =>
        {
            entity.HasKey(e => e.Hid).HasName("PK__HOSPITAL__C7551527520749D6");

            entity.ToTable("HOSPITALITY");

            entity.HasIndex(e => e.Hname, "UQ__HOSPITAL__B3244A5CBADF0096").IsUnique();

            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Hname)
                .HasMaxLength(255)
                .HasColumnName("HName");
            entity.Property(e => e.Hrating).HasColumnName("HRating");
            entity.Property(e => e.Htype)
                .HasMaxLength(255)
                .HasColumnName("HType");
            entity.Property(e => e.Lid).HasColumnName("LID");

            entity.HasOne(d => d.LidNavigation).WithMany(p => p.Hospitalities)
                .HasForeignKey(d => d.Lid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOSPITALITY__LID__3F466844");
        });

        modelBuilder.Entity<Landmark>(entity =>
        {
            entity.HasKey(e => e.Lid).HasName("PK__LANDMARK__C65557218EC6787B");

            entity.ToTable("LANDMARKS");

            entity.HasIndex(e => e.Lname, "UQ__LANDMARK__02911AAE4AE50D45").IsUnique();

            entity.Property(e => e.Lid).HasColumnName("LID");
            entity.Property(e => e.Lname)
                .HasMaxLength(255)
                .HasColumnName("LName");
            entity.Property(e => e.Ltype)
                .HasMaxLength(255)
                .HasColumnName("LType");
        });

        modelBuilder.Entity<Travelplan>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__TRAVELPL__C5775520409AE4D2");

            entity.ToTable("TRAVELPLAN");

            entity.HasIndex(e => e.Aid, "UQ__TRAVELPL__C69007C96192873F").IsUnique();

            entity.HasIndex(e => e.Hid, "UQ__TRAVELPL__C755152638E75731").IsUnique();

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PID");
            entity.Property(e => e.Aid).HasColumnName("AID");
            entity.Property(e => e.Hid).HasColumnName("HID");
            
                

            //entity.HasOne(d => d.AidNavigation).WithOne(p => p.Travelplan)
            //    .HasForeignKey<Travelplan>(d => d.Aid)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__TRAVELPLAN__AID__44FF419A");

        //    entity.HasOne(d => d.HidNavigation).WithOne(p => p.Travelplan)
        //        .HasForeignKey<Travelplan>(d => d.Hid)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK__TRAVELPLAN__HID__440B1D61");
        });

        modelBuilder.Entity<UserTravel>(entity =>
        {
            entity.HasKey(e => e.Utid).HasName("PK__UserTrav__5A6477EEBC9C83D4");

            entity.ToTable("UserTravel");

            entity.Property(e => e.Utid).HasColumnName("UTID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Uid).HasColumnName("UID");

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.UserTravels)
                .HasForeignKey(d => d.Pid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserTravel__PID__4AB81AF0");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.UserTravels)
                .HasForeignKey(d => d.Uid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserTravel__UID__4BAC3F29");
        });

        modelBuilder.Entity<Userdatum>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__USERDATA__C5B19602591CB00C");

            entity.ToTable("USERDATA");

            entity.HasIndex(e => e.Uemail, "UQ__USERDATA__75B1691EEB5A55C1").IsUnique();

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Uemail)
                .HasMaxLength(255)
                .HasColumnName("UEmail");
            entity.Property(e => e.Ufname)
                .HasMaxLength(255)
                .HasColumnName("UFName");
            entity.Property(e => e.Ulname)
                .HasMaxLength(255)
                .HasColumnName("ULName");
            entity.Property(e => e.Uphone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UPhone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
