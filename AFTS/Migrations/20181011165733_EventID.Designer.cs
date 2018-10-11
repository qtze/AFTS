﻿// <auto-generated />
using System;
using AFTS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AFTS.Migrations
{
    [DbContext(typeof(tennisContext))]
    [Migration("20181011165733_EventID")]
    partial class EventID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("Date")
                        .HasColumnName("date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<int>("MemberId")
                        .HasColumnName("member_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("EventId");

                    b.HasIndex("MemberId");

                    b.ToTable("event");
                });

            modelBuilder.Entity("AFTS.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("member_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .IsRequired();

                    b.Property<DateTime>("Dob")
                        .HasColumnName("dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("gender")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("Nickname")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasDefaultValue(3);

                    b.HasKey("MemberId");

                    b.HasIndex("RoleId");

                    b.ToTable("member");
                });

            modelBuilder.Entity("AFTS.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleType")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_type")
                        .HasDefaultValue("Member");

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

                    b.HasIndex("EventId");

                    b.HasIndex("MemberId");

                    b.ToTable("schedule");
                });

            modelBuilder.Entity("AFTS.Models.Event", b =>
                {
                    b.HasOne("AFTS.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AFTS.Models.Member", b =>
                {
                    b.HasOne("AFTS.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AFTS.Models.Schedule", b =>
                {
                    b.HasOne("AFTS.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AFTS.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
