﻿// <auto-generated />
using System;
using Anemoi.Notification.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Anemoi.Notification.Infrastructure.Migrations
{
    [DbContext(typeof(NotificationDbContext))]
    partial class NotificationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Anemoi.Notification.Domain.Models.EmailConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Host")
                        .HasColumnType("text");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSslEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordBytes")
                        .HasColumnType("bytea");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.Property<string>("SearchHint")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("WorkspaceId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("EmailConfigurations");
                });

            modelBuilder.Entity("Anemoi.Notification.Domain.Models.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsTrash")
                        .HasColumnType("boolean");

                    b.Property<string>("Parameters")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TargetUserId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WorkspaceId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TargetUserId");

                    b.HasIndex("TargetUserId", "WorkspaceId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Anemoi.Notification.Domain.Models.NotificationTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NotificationTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}