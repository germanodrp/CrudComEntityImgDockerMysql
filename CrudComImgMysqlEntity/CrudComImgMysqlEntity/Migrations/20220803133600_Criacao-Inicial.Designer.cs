﻿// <auto-generated />
using CrudComImgMysqlEntity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudComImgMysqlEntity.Migrations
{
    [DbContext(typeof(ContextVeiculos))]
    [Migration("20220803133600_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CrudComImgMysqlEntity.Models.Veiculo", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("AnoModelo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("AnoModelo");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Marca");

                    b.Property<string>("Modalidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Modalidade");

                    b.Property<string>("NomeDoVeiculo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NomeDoVeiculo");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Placa");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
