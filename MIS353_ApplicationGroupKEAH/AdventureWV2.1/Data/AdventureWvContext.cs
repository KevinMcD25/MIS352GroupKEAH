using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdventureWV2._1.Data;

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
            entity.HasKey(e => e.Aid).HasName("PK__ACTIVITI__C69007C889972C38");

            entity.ToTable("ACTIVITIES");

            entity.HasIndex(e => new { e.Aname, e.Lid }, "ADSD").IsUnique();

            entity.Property(e => e.Aid).HasColumnName("AID");
            entity.Property(e => e.Aname)
                .HasMaxLength(255)
                .HasColumnName("AName");
            entity.Property(e => e.Lid).HasColumnName("LID");

   //         entity.HasOne(d => d.LidNavigation).WithMany(p => p.Activities)
   //             .HasForeignKey(d => d.Lid)
   //             .OnDelete(DeleteBehavior.ClientSetNull)
   //             .HasConstraintName("FK__ACTIVITIES__LID__3A81B327");
        });

        modelBuilder.Entity<Hospitality>(entity =>
        {
            entity.HasKey(e => e.Hid).HasName("PK__HOSPITAL__C7551527BDF3078E");

            entity.ToTable("HOSPITALITY");

            entity.HasIndex(e => e.Hname, "UQ__HOSPITAL__B3244A5C2B8FA465").IsUnique();

            entity.Property(e => e.Hid).HasColumnName("HID");
            entity.Property(e => e.Hname)
                .HasMaxLength(255)
                .HasColumnName("HName");
            entity.Property(e => e.Hrating).HasColumnName("HRating");
            entity.Property(e => e.Htype)
                .HasMaxLength(255)
                .HasColumnName("HType");
            entity.Property(e => e.Lid).HasColumnName("LID");

         ///   entity.HasOne(d => d.LidNavigation).WithMany(p => p.Hospitalities)
          //      .HasForeignKey(d => d.Lid)
           //     .OnDelete(DeleteBehavior.ClientSetNull)
           //     .HasConstraintName("FK__HOSPITALITY__LID__3F466844");
        });

        modelBuilder.Entity<Landmark>(entity =>
        {
            entity.HasKey(e => e.Lid).HasName("PK__LANDMARK__C65557219E81F099");

            entity.ToTable("LANDMARKS");

            entity.HasIndex(e => e.Lname, "UQ__LANDMARK__02911AAE72408299").IsUnique();

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
            entity.HasKey(e => e.Pid).HasName("PK__TRAVELPL__C57755209E2A2171");

            entity.ToTable("TRAVELPLAN");

            entity.HasIndex(e => new { e.Hid, e.Aid }, "ADLD").IsUnique();

            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Aid).HasColumnName("AID");
            entity.Property(e => e.Hid).HasColumnName("HID");

           // entity.HasOne(d => d.AidNavigation).WithMany(p => p.Travelplans)
           //     .HasForeignKey(d => d.Aid)
           //     .OnDelete(DeleteBehavior.ClientSetNull)
           //     .HasConstraintName("FK__TRAVELPLAN__AID__4316F928");

        //    entity.HasOne(d => d.HidNavigation).WithMany(p => p.Travelplans)
          //      .HasForeignKey(d => d.Hid)
           //     .OnDelete(DeleteBehavior.ClientSetNull)
           //     .HasConstraintName("FK__TRAVELPLAN__HID__4222D4EF");
        });

        modelBuilder.Entity<UserTravel>(entity =>
        {
            entity.HasKey(e => e.Utid).HasName("PK__UserTrav__5A6477EEA23E8123");

            entity.ToTable("UserTravel");

            entity.Property(e => e.Utid).HasColumnName("UTID");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.UtdateTime)
                .HasColumnType("datetime")
                .HasColumnName("UTDateTime");

         //   entity.HasOne(d => d.PidNavigation).WithMany(p => p.UserTravels)
          //      .HasForeignKey(d => d.Pid)
          //      .OnDelete(DeleteBehavior.ClientSetNull)
          //      .HasConstraintName("FK__UserTravel__PID__49C3F6B7");

          //  entity.HasOne(d => d.UidNavigation).WithMany(p => p.UserTravels)
           //    .HasForeignKey(d => d.Uid)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__UserTravel__UID__4AB81AF0");
        });

        modelBuilder.Entity<Userdatum>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__USERDATA__C5B1960219343F70");

            entity.ToTable("USERDATA");

            entity.HasIndex(e => e.Uemail, "UQ__USERDATA__75B1691E6E8EA055").IsUnique();

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
