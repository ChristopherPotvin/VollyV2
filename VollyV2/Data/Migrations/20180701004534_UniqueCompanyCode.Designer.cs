﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using VollyV2.Data;

namespace VollyV2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180701004534_UniqueCompanyCode")]
    partial class UniqueCompanyCode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<int?>("OpportunityId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.ApplicationOccurrence", b =>
                {
                    b.Property<int>("ApplicationId");

                    b.Property<int>("OccurrenceId");

                    b.HasKey("ApplicationId", "OccurrenceId");

                    b.HasIndex("OccurrenceId");

                    b.ToTable("ApplicationsOccurrence");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Searches");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Cause", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Causes");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Community", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.ToTable("Communities");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CompanyCode");

                    b.Property<string>("ContactEmail");

                    b.Property<string>("Description");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CompanyCode")
                        .IsUnique()
                        .HasFilter("[CompanyCode] IS NOT NULL");

                    b.HasIndex("LocationId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Occurrence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ApplicationDeadline");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("Openings");

                    b.Property<int>("OpportunityId");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Id");

                    b.HasIndex("OpportunityId");

                    b.ToTable("Occurrences");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("CreatedByUserId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.OpportunityImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrl");

                    b.Property<int>("OpportunityId");

                    b.HasKey("Id");

                    b.HasIndex("OpportunityId");

                    b.ToTable("OpportunityImages");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int?>("CauseId");

                    b.Property<string>("ContactEmail");

                    b.Property<string>("FullDescription");

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("LocationId");

                    b.Property<string>("MissionStatement");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("WebsiteLink");

                    b.HasKey("Id");

                    b.HasIndex("CauseId");

                    b.HasIndex("LocationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.VolunteerHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<double>("Hours");

                    b.Property<int>("OccurrenceId");

                    b.Property<string>("OrganizationName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OccurrenceId");

                    b.HasIndex("UserId");

                    b.ToTable("VolunteerHours");
                });

            modelBuilder.Entity("VollyV2.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfileImage");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("VollyV2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("VollyV2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VollyV2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("VollyV2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Application", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Opportunity", "Opportunity")
                        .WithMany()
                        .HasForeignKey("OpportunityId");

                    b.HasOne("VollyV2.Models.ApplicationUser", "User")
                        .WithMany("Applications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.ApplicationOccurrence", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Application", "Application")
                        .WithMany("Occurrences")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VollyV2.Data.Volly.Occurrence", "Occurrence")
                        .WithMany("Applications")
                        .HasForeignKey("OccurrenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Company", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Occurrence", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Opportunity", "Opportunity")
                        .WithMany("Occurrences")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Opportunity", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("VollyV2.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("VollyV2.Data.Volly.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("VollyV2.Data.Volly.Organization", "Organization")
                        .WithMany("Opportunities")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.OpportunityImage", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Opportunity", "Opportunity")
                        .WithMany("OpportunityImages")
                        .HasForeignKey("OpportunityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VollyV2.Data.Volly.Organization", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Cause", "Cause")
                        .WithMany()
                        .HasForeignKey("CauseId");

                    b.HasOne("VollyV2.Data.Volly.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("VollyV2.Data.Volly.VolunteerHours", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Occurrence", "Occurrence")
                        .WithMany()
                        .HasForeignKey("OccurrenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VollyV2.Models.ApplicationUser", "User")
                        .WithMany("VolunteerHours")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VollyV2.Models.ApplicationUser", b =>
                {
                    b.HasOne("VollyV2.Data.Volly.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
