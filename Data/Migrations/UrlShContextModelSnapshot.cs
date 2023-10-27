﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrlSh.Data;

#nullable disable

namespace UrlSh.Data.Migrations
{
    [DbContext(typeof(UrlShContext))]
    partial class UrlShContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UrlSh.Data.Models.Redirect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("(NOW())");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Redirects", (string)null);
                });

            modelBuilder.Entity("UrlSh.Data.Models.RedirectLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("(NOW())");

                    b.Property<string>("IPAddress")
                        .HasColumnType("longtext");

                    b.Property<int>("RedirectId")
                        .HasColumnType("int");

                    b.Property<string>("Referer")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RedirectId");

                    b.ToTable("RedirectLogs", (string)null);
                });

            modelBuilder.Entity("UrlSh.Data.Models.RedirectLog", b =>
                {
                    b.HasOne("UrlSh.Data.Models.Redirect", "Redirect")
                        .WithMany("Logs")
                        .HasForeignKey("RedirectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Redirect");
                });

            modelBuilder.Entity("UrlSh.Data.Models.Redirect", b =>
                {
                    b.Navigation("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}