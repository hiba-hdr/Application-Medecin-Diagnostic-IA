﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_InterfaceWeb.Models;

#nullable disable

namespace TP_InterfaceWeb.Migrations
{
    [DbContext(typeof(MedecinDbContext))]
    [Migration("20220414045137_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TP_InterfaceWeb.Models.AjoutPatient", b =>
                {
                    b.Property<int>("AjoutPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DateNaissance")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("DernierDiagnostic")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FemmeCheck")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HommeCheck")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AjoutPatientId");

                    b.ToTable("AjoutPatients");
                });

            modelBuilder.Entity("TP_InterfaceWeb.Models.Diagnostic", b =>
                {
                    b.Property<int>("DiagnosticId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DS")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NG")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Resultat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Thalassemie")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TypeDouleur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DiagnosticId");

                    b.ToTable("Diagnostics");
                });

            modelBuilder.Entity("TP_InterfaceWeb.Models.Infomedecin", b =>
                {
                    b.Property<int>("InfomedecinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateDebutCarriere")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("DateNaissance")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FemmeCheck")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HommeCheck")
                        .IsRequired()
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

                    b.HasKey("InfomedecinId");

                    b.ToTable("Infomedecins");
                });

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
