﻿// <auto-generated />
using System;
using ExameBE.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExameBE.Infrastructure.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20220624124014_contact")]
    partial class contact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ExameBE.Domain.Model.Anuncio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AdType")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(400)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Ads");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdType = 0,
                            Contact = "93XXXXXXX",
                            CreationDate = new DateTime(2022, 6, 24, 13, 40, 14, 74, DateTimeKind.Local).AddTicks(3650),
                            Description = "Com garagem. Acessos. Escolas. Metro.",
                            Subject = "T2, Vila Nova de Gaia, 2014, 250000€"
                        },
                        new
                        {
                            Id = 2,
                            AdType = 2,
                            Contact = "93XXXXXXX",
                            CreationDate = new DateTime(2022, 6, 24, 13, 40, 14, 91, DateTimeKind.Local).AddTicks(8080),
                            Description = "Salário: 1500-2000€ mensais. Entrada imediata. Missões: - Avaliação Imobiliária! - Mediação e Angariação Imobiliária! - Apoio á construção, obras, remodelações e Projetos Arquitetura!",
                            Subject = "Zome, Porto, Consultor, Júnior, Full-time"
                        },
                        new
                        {
                            Id = 3,
                            AdType = 1,
                            Contact = "93XXXXXXX",
                            CreationDate = new DateTime(2022, 6, 24, 13, 40, 14, 91, DateTimeKind.Local).AddTicks(8900),
                            Description = "Revisão feita sempre na marca. Como novo.",
                            Subject = "Mazda CX-5, Loulé, 2018, 40000 Km, 27000€"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
