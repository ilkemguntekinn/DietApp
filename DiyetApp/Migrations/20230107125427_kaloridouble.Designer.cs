﻿// <auto-generated />
using System;
using DiyetApp.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyetApp.Migrations
{
    [DbContext(typeof(DiyetDbContext))]
    [Migration("20230107125427_kaloridouble")]
    partial class kaloridouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiyetApp.Besinler.BesinPorsiyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("Porsiyon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("BesinPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Besinler.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("DiyetApp.Kullanici.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdminAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adminler");
                });

            modelBuilder.Entity("DiyetApp.Kullanici.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Boy")
                        .HasColumnType("int");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GizliYanit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kilo")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("DiyetApp.Ogunler.Ogun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("OgunAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OgunAd = "Sabah"
                        },
                        new
                        {
                            Id = 2,
                            OgunAd = "Öğle"
                        },
                        new
                        {
                            Id = 3,
                            OgunAd = "Akşam"
                        });
                });

            modelBuilder.Entity("DiyetApp.Ogunler.UyeYemek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BesinId")
                        .HasColumnType("int");

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<int>("UyeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Zaman")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BesinId");

                    b.HasIndex("OgunId");

                    b.HasIndex("UyeId");

                    b.ToTable("UyeYemekler");
                });

            modelBuilder.Entity("DiyetApp.Besinler.BesinPorsiyon", b =>
                {
                    b.HasOne("DiyetApp.Besinler.Kategori", "Kategori")
                        .WithMany("BesinPorsiyonlar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DiyetApp.Ogunler.UyeYemek", b =>
                {
                    b.HasOne("DiyetApp.Besinler.BesinPorsiyon", "Besin")
                        .WithMany("UyeYemekler")
                        .HasForeignKey("BesinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetApp.Ogunler.Ogun", "Ogun")
                        .WithMany("UyeYemekler")
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetApp.Kullanici.Uye", "Uye")
                        .WithMany("UyeYemekler")
                        .HasForeignKey("UyeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Besin");

                    b.Navigation("Ogun");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("DiyetApp.Besinler.BesinPorsiyon", b =>
                {
                    b.Navigation("UyeYemekler");
                });

            modelBuilder.Entity("DiyetApp.Besinler.Kategori", b =>
                {
                    b.Navigation("BesinPorsiyonlar");
                });

            modelBuilder.Entity("DiyetApp.Kullanici.Uye", b =>
                {
                    b.Navigation("UyeYemekler");
                });

            modelBuilder.Entity("DiyetApp.Ogunler.Ogun", b =>
                {
                    b.Navigation("UyeYemekler");
                });
#pragma warning restore 612, 618
        }
    }
}
