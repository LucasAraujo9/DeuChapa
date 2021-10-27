﻿// <auto-generated />
using System;
using DeuChapa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeuChapa.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211011183945_MeuDbChapa")]
    partial class MeuDbChapa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeuChapa.Models.Bebida", b =>
                {
                    b.Property<int>("Id_Bebida")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<string>("Tipo");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id_Bebida");

                    b.ToTable("Bebida");
                });

            modelBuilder.Entity("DeuChapa.Models.Combo", b =>
                {
                    b.Property<int>("Id_Combo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BebidaId_Bebida");

                    b.Property<int?>("LancheId_Lanche");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id_Combo");

                    b.HasIndex("BebidaId_Bebida");

                    b.HasIndex("LancheId_Lanche");

                    b.ToTable("Combo");
                });

            modelBuilder.Entity("DeuChapa.Models.Ingredientes", b =>
                {
                    b.Property<int>("Id_Ingrediente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Alface");

                    b.Property<string>("Hamburguer");

                    b.Property<string>("Molho");

                    b.Property<string>("Pao");

                    b.Property<string>("Queijo");

                    b.Property<bool>("Tomate");

                    b.HasKey("Id_Ingrediente");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("DeuChapa.Models.Lanche", b =>
                {
                    b.Property<int>("Id_Lanche")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IngredientesId_Ingrediente");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id_Lanche");

                    b.HasIndex("IngredientesId_Ingrediente");

                    b.ToTable("Lanche");
                });

            modelBuilder.Entity("DeuChapa.Models.Combo", b =>
                {
                    b.HasOne("DeuChapa.Models.Bebida", "Bebida")
                        .WithMany()
                        .HasForeignKey("BebidaId_Bebida");

                    b.HasOne("DeuChapa.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("LancheId_Lanche");
                });

            modelBuilder.Entity("DeuChapa.Models.Lanche", b =>
                {
                    b.HasOne("DeuChapa.Models.Ingredientes", "Ingredientes")
                        .WithMany()
                        .HasForeignKey("IngredientesId_Ingrediente");
                });
#pragma warning restore 612, 618
        }
    }
}
