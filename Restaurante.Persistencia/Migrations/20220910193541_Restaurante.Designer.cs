﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurante.Persistencia;

namespace Restaurante.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220910193541_Restaurante")]
    partial class Restaurante
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Restaurante.Dominio.Asignacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("Asignaciones");
                });

            modelBuilder.Entity("Restaurante.Dominio.Comanda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("mesaid")
                        .HasColumnType("int");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("mesaid");

                    b.HasIndex("personaid");

                    b.ToTable("Comandas");
                });

            modelBuilder.Entity("Restaurante.Dominio.Deta_Fact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cant")
                        .HasColumnType("int");

                    b.Property<int?>("facturaid")
                        .HasColumnType("int");

                    b.Property<int?>("menuid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("facturaid");

                    b.HasIndex("menuid");

                    b.ToTable("Deta_Facts");
                });

            modelBuilder.Entity("Restaurante.Dominio.Detal_Asignacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("asignacionid")
                        .HasColumnType("int");

                    b.Property<int?>("mesaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("asignacionid");

                    b.HasIndex("mesaid");

                    b.ToTable("Detal_Asignaciones");
                });

            modelBuilder.Entity("Restaurante.Dominio.Detal_comanda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cant")
                        .HasColumnType("int");

                    b.Property<int?>("comandaid")
                        .HasColumnType("int");

                    b.Property<int?>("menuid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("comandaid");

                    b.HasIndex("menuid");

                    b.ToTable("Detal_comandas");
                });

            modelBuilder.Entity("Restaurante.Dominio.Factura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("idcomandaid")
                        .HasColumnType("int");

                    b.Property<int?>("mesaid")
                        .HasColumnType("int");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("idcomandaid");

                    b.HasIndex("mesaid");

                    b.HasIndex("personaid");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Restaurante.Dominio.Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("idRolid")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idRolid");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("Restaurante.Dominio.Menu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precio")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Restaurante.Dominio.Mesa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("Restaurante.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Restaurante.Dominio.TipoPersona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("idpersona")
                        .HasColumnType("int");

                    b.Property<string>("tipoP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("Restaurante.Dominio.Rol", b =>
                {
                    b.HasBaseType("Restaurante.Dominio.Persona");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoRol")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Rol");
                });

            modelBuilder.Entity("Restaurante.Dominio.Asignacion", b =>
                {
                    b.HasOne("Restaurante.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("Restaurante.Dominio.Comanda", b =>
                {
                    b.HasOne("Restaurante.Dominio.Mesa", "mesa")
                        .WithMany()
                        .HasForeignKey("mesaid");

                    b.HasOne("Restaurante.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("mesa");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("Restaurante.Dominio.Deta_Fact", b =>
                {
                    b.HasOne("Restaurante.Dominio.Factura", "factura")
                        .WithMany()
                        .HasForeignKey("facturaid");

                    b.HasOne("Restaurante.Dominio.Menu", "menu")
                        .WithMany()
                        .HasForeignKey("menuid");

                    b.Navigation("factura");

                    b.Navigation("menu");
                });

            modelBuilder.Entity("Restaurante.Dominio.Detal_Asignacion", b =>
                {
                    b.HasOne("Restaurante.Dominio.Asignacion", "asignacion")
                        .WithMany()
                        .HasForeignKey("asignacionid");

                    b.HasOne("Restaurante.Dominio.Mesa", "mesa")
                        .WithMany()
                        .HasForeignKey("mesaid");

                    b.Navigation("asignacion");

                    b.Navigation("mesa");
                });

            modelBuilder.Entity("Restaurante.Dominio.Detal_comanda", b =>
                {
                    b.HasOne("Restaurante.Dominio.Comanda", "comanda")
                        .WithMany()
                        .HasForeignKey("comandaid");

                    b.HasOne("Restaurante.Dominio.Menu", "menu")
                        .WithMany()
                        .HasForeignKey("menuid");

                    b.Navigation("comanda");

                    b.Navigation("menu");
                });

            modelBuilder.Entity("Restaurante.Dominio.Factura", b =>
                {
                    b.HasOne("Restaurante.Dominio.Comanda", "idcomanda")
                        .WithMany()
                        .HasForeignKey("idcomandaid");

                    b.HasOne("Restaurante.Dominio.Mesa", "mesa")
                        .WithMany()
                        .HasForeignKey("mesaid");

                    b.HasOne("Restaurante.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("idcomanda");

                    b.Navigation("mesa");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("Restaurante.Dominio.Login", b =>
                {
                    b.HasOne("Restaurante.Dominio.Rol", "idRol")
                        .WithMany()
                        .HasForeignKey("idRolid");

                    b.Navigation("idRol");
                });
#pragma warning restore 612, 618
        }
    }
}