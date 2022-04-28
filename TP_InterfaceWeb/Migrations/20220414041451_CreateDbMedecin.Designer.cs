﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_InterfaceWeb.Models;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    [DbContext(typeof(MedecinDbContext))]
    [Migration("20220414041451_CreateDbMedecin")]
    partial class CreateDbMedecin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TP_InterfaceWeb.Models.Medecin", b =>
                {
                    b.Property<int>("MedecinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MultiView1")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MedecinID");

                    b.ToTable("Medecins");
                });

            modelBuilder.Entity("TP_InterfaceWeb.Models.NewAccount", b =>
                {
                    b.Property<int>("NewAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateEntree")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DateNaissance")
                        .HasColumnType("longtext");

                    b.Property<string>("FemmeCheck")
                        .HasColumnType("longtext");

                    b.Property<string>("HommeCheck")
                        .HasColumnType("longtext");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("NewAccountID");

                    b.ToTable("NewAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
