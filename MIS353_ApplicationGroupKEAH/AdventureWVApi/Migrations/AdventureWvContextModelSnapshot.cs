﻿// <auto-generated />
using System;
using AdventureWVApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdventureWVApi.Migrations
{
    [DbContext(typeof(AdventureWvContext))]
    partial class AdventureWvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdventureWVApi.Data.Activity", b =>
                {
                    b.Property<int>("Aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Aid"));

                    b.Property<string>("Aname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("AName");

                    b.Property<int>("Lid")
                        .HasColumnType("int")
                        .HasColumnName("LID");

                    b.HasKey("Aid")
                        .HasName("PK__ACTIVITI__C69007C8F1F72C4B");

                    b.HasIndex("Lid");

                    b.HasIndex(new[] { "Aname", "Lid" }, "ADSD")
                        .IsUnique();

                    b.ToTable("ACTIVITIES", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.Hospitality", b =>
                {
                    b.Property<int>("Hid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("HID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hid"));

                    b.Property<string>("Hname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("HName");

                    b.Property<int?>("Hrating")
                        .HasColumnType("int")
                        .HasColumnName("HRating");

                    b.Property<string>("Htype")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("HType");

                    b.Property<int?>("LandmarkLid")
                        .HasColumnType("int");

                    b.Property<int>("Lid")
                        .HasColumnType("int")
                        .HasColumnName("LID");

                    b.HasKey("Hid")
                        .HasName("PK__HOSPITAL__C7551527520749D6");

                    b.HasIndex("LandmarkLid");

                    b.HasIndex(new[] { "Hname" }, "UQ__HOSPITAL__B3244A5CBADF0096")
                        .IsUnique();

                    b.ToTable("HOSPITALITY", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.Landmark", b =>
                {
                    b.Property<int>("Lid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lid"));

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("LName");

                    b.Property<string>("Ltype")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("LType");

                    b.HasKey("Lid")
                        .HasName("PK__LANDMARK__C65557218EC6787B");

                    b.HasIndex(new[] { "Lname" }, "UQ__LANDMARK__02911AAE4AE50D45")
                        .IsUnique();

                    b.ToTable("LANDMARKS", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.Travelplan", b =>
                {
                    b.Property<int>("Pid")
                        .HasColumnType("int")
                        .HasColumnName("PID");

                    b.Property<int>("Aid")
                        .HasColumnType("int")
                        .HasColumnName("AID");

                    b.Property<int>("AidNavigationAid")
                        .HasColumnType("int");

                    b.Property<int>("Hid")
                        .HasColumnType("int")
                        .HasColumnName("HID");

                    b.Property<int>("HidNavigationHid")
                        .HasColumnType("int");

                    b.HasKey("Pid")
                        .HasName("PK__TRAVELPL__C5775520409AE4D2");

                    b.HasIndex("AidNavigationAid");

                    b.HasIndex("HidNavigationHid");

                    b.HasIndex(new[] { "Aid" }, "UQ__TRAVELPL__C69007C96192873F")
                        .IsUnique();

                    b.HasIndex(new[] { "Hid" }, "UQ__TRAVELPL__C755152638E75731")
                        .IsUnique();

                    b.ToTable("TRAVELPLAN", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.UserTravel", b =>
                {
                    b.Property<int>("Utid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Utid"));

                    b.Property<int>("Pid")
                        .HasColumnType("int")
                        .HasColumnName("PID");

                    b.Property<DateTime>("UTDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Uid")
                        .HasColumnType("int")
                        .HasColumnName("UID");

                    b.HasKey("Utid")
                        .HasName("PK__UserTrav__5A6477EEBC9C83D4");

                    b.HasIndex("Pid");

                    b.HasIndex("Uid");

                    b.ToTable("UserTravel", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.Userdatum", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Uid"));

                    b.Property<string>("Uemail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("UEmail");

                    b.Property<string>("Ufname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("UFName");

                    b.Property<string>("Ulname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("ULName");

                    b.Property<string>("Uphone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("UPhone");

                    b.HasKey("Uid")
                        .HasName("PK__USERDATA__C5B19602591CB00C");

                    b.HasIndex(new[] { "Uemail" }, "UQ__USERDATA__75B1691EEB5A55C1")
                        .IsUnique();

                    b.ToTable("USERDATA", (string)null);
                });

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("AdventureWVApi.Data.Activity", b =>
                {
                    b.HasOne("AdventureWVApi.Data.Landmark", "LidNavigation")
                        .WithMany("Activities")
                        .HasForeignKey("Lid")
                        .IsRequired()
                        .HasConstraintName("FK__ACTIVITIES__LID__3A81B327");

                    b.Navigation("LidNavigation");
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetRoleClaim", b =>
                {
                    b.HasOne("AdventureWVApi.Data.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUserClaim", b =>
                {
                    b.HasOne("AdventureWVApi.Data.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUserLogin", b =>
                {
                    b.HasOne("AdventureWVApi.Data.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUserToken", b =>
                {
                    b.HasOne("AdventureWVApi.Data.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AdventureWVApi.Data.Hospitality", b =>
                {
                    b.HasOne("AdventureWVApi.Data.Landmark", null)
                        .WithMany("Hospitalities")
                        .HasForeignKey("LandmarkLid");
                });

            modelBuilder.Entity("AdventureWVApi.Data.Travelplan", b =>
                {
                    b.HasOne("AdventureWVApi.Data.Activity", "AidNavigation")
                        .WithMany()
                        .HasForeignKey("AidNavigationAid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdventureWVApi.Data.Hospitality", "HidNavigation")
                        .WithMany()
                        .HasForeignKey("HidNavigationHid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AidNavigation");

                    b.Navigation("HidNavigation");
                });

            modelBuilder.Entity("AdventureWVApi.Data.UserTravel", b =>
                {
                    b.HasOne("AdventureWVApi.Data.Travelplan", "PidNavigation")
                        .WithMany("UserTravels")
                        .HasForeignKey("Pid")
                        .IsRequired()
                        .HasConstraintName("FK__UserTravel__PID__4AB81AF0");

                    b.HasOne("AdventureWVApi.Data.Userdatum", "UidNavigation")
                        .WithMany("UserTravels")
                        .HasForeignKey("Uid")
                        .IsRequired()
                        .HasConstraintName("FK__UserTravel__UID__4BAC3F29");

                    b.Navigation("PidNavigation");

                    b.Navigation("UidNavigation");
                });

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.HasOne("AdventureWVApi.Data.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdventureWVApi.Data.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");
                });

            modelBuilder.Entity("AdventureWVApi.Data.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserTokens");
                });

            modelBuilder.Entity("AdventureWVApi.Data.Landmark", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Hospitalities");
                });

            modelBuilder.Entity("AdventureWVApi.Data.Travelplan", b =>
                {
                    b.Navigation("UserTravels");
                });

            modelBuilder.Entity("AdventureWVApi.Data.Userdatum", b =>
                {
                    b.Navigation("UserTravels");
                });
#pragma warning restore 612, 618
        }
    }
}
