﻿// <auto-generated />
using BusApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusApp.Data.Migrations
{
    [DbContext(typeof(BusBiletContext))]
    [Migration("20220517125644_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BiletGuzergah", b =>
                {
                    b.Property<int>("BiletsBiletId")
                        .HasColumnType("int");

                    b.Property<int>("GuzergahsGuzergahId")
                        .HasColumnType("int");

                    b.HasKey("BiletsBiletId", "GuzergahsGuzergahId");

                    b.HasIndex("GuzergahsGuzergahId");

                    b.ToTable("BiletGuzergah");
                });

            modelBuilder.Entity("BusApp.Entity.Bilet", b =>
                {
                    b.Property<int>("BiletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<int>("KoltukNo")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nereden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nereye")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BiletId");

                    b.ToTable("Bilets");
                });

            modelBuilder.Entity("BusApp.Entity.Guzergah", b =>
                {
                    b.Property<int>("GuzergahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslangıc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bitis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Saat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gz1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gz2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuzergahId");

                    b.ToTable("Guzergahs");
                });

            modelBuilder.Entity("BusApp.Entity.Sehir", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SehirAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SehirId");

                    b.ToTable("Sehirs");
                });

            modelBuilder.Entity("BiletGuzergah", b =>
                {
                    b.HasOne("BusApp.Entity.Bilet", null)
                        .WithMany()
                        .HasForeignKey("BiletsBiletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusApp.Entity.Guzergah", null)
                        .WithMany()
                        .HasForeignKey("GuzergahsGuzergahId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
