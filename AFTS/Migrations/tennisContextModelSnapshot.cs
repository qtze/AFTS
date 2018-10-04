﻿// <auto-generated />
using System;
using AFTS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AFTS.Migrations
{
    [DbContext(typeof(tennisContext))]
    partial class tennisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AFTS.Models.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("coach_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnName("biography")
                        .HasColumnType("text");

                    b.Property<DateTime>("Dob")
                        .HasColumnName("dob")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Nickname")
                        .HasColumnName("nickname")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("CoachId");

                    b.ToTable("coach");
                });

            modelBuilder.Entity("AFTS.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("event_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Coach")
                        .HasColumnName("coach");

                    b.Property<DateTime>("Date")
                        .HasColumnName("date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("EventId");

                    b.ToTable("event");
                });

            modelBuilder.Entity("AFTS.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("member_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob")
                        .HasColumnName("dob")
                        .HasColumnType("date");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("gender")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<int?>("RoleTypeRoleId");

                    b.HasKey("MemberId");

                    b.HasIndex("RoleTypeRoleId");

                    b.ToTable("member");
                });

            modelBuilder.Entity("AFTS.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleType")
                        .HasColumnName("role_type");

                    b.HasKey("RoleId");

                    b.ToTable("role");
                });

            modelBuilder.Entity("AFTS.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("schedule_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId")
                        .HasColumnName("event_id");

                    b.Property<int>("MemberId")
                        .HasColumnName("member_id");

                    b.HasKey("ScheduleId");

                    b.ToTable("schedule");
                });

            modelBuilder.Entity("AFTS.Models.Member", b =>
                {
                    b.HasOne("AFTS.Models.Role", "RoleType")
                        .WithMany()
                        .HasForeignKey("RoleTypeRoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
