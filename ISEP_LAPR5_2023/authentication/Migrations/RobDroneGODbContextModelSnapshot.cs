﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RobDroneGO.Infrastructure;

namespace DDDNetCore.Migrations
{
    [DbContext(typeof(RobDroneGODbContext))]
    partial class RobDroneGODbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RobDroneGO.Domain.Pedidos.Pedido", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<DateTime>("DataMudancaEstado")
                        .HasColumnType("datetime")
                        .HasColumnName("DataMudancaEstado");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime")
                        .HasColumnName("DataPedido");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("Estado");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("RobDroneGO.Domain.Roles.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RobDroneGO.Domain.Users.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RobDroneGO.Domain.Pedidos.Pedido", b =>
                {
                    b.OwnsOne("RobDroneGO.Domain.Pedidos.PedidoEmail", "Email", b1 =>
                        {
                            b1.Property<string>("PedidoId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("varchar(767)")
                                .HasColumnName("Email");

                            b1.HasKey("PedidoId");

                            b1.HasIndex("Email")
                                .IsUnique();

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Pedidos.PedidoNIF", "NIF", b1 =>
                        {
                            b1.Property<string>("PedidoId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("NIF")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("NIF");

                            b1.HasKey("PedidoId");

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Pedidos.PedidoPassword", "Password", b1 =>
                        {
                            b1.Property<string>("PedidoId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Password");

                            b1.HasKey("PedidoId");

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Pedidos.PedidoPhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<string>("PedidoId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasColumnType("varchar(767)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("PedidoId");

                            b1.HasIndex("PhoneNumber")
                                .IsUnique();

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Pedidos.PedidoUserName", "Name", b1 =>
                        {
                            b1.Property<string>("PedidoId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Name");

                            b1.HasKey("PedidoId");

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoId");
                        });

                    b.Navigation("Email");

                    b.Navigation("Name");

                    b.Navigation("NIF");

                    b.Navigation("Password");

                    b.Navigation("PhoneNumber");
                });

            modelBuilder.Entity("RobDroneGO.Domain.Roles.Role", b =>
                {
                    b.OwnsOne("RobDroneGO.Domain.Roles.RoleName", "Name", b1 =>
                        {
                            b1.Property<string>("RoleId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Name");

                            b1.HasKey("RoleId");

                            b1.ToTable("Roles");

                            b1.WithOwner()
                                .HasForeignKey("RoleId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("RobDroneGO.Domain.Users.User", b =>
                {
                    b.HasOne("RobDroneGO.Domain.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("RobDroneGO.Domain.Users.UserEmail", "Email", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("varchar(767)")
                                .HasColumnName("Email");

                            b1.HasKey("UserId");

                            b1.HasIndex("Email")
                                .IsUnique();

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Users.UserNIF", "NIF", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("NIF")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("NIF");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Users.UserName", "Name", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Name");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Users.UserPassword", "Password", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("Password")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Password");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.OwnsOne("RobDroneGO.Domain.Users.UserPhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(767)");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasColumnType("varchar(767)")
                                .HasColumnName("PhoneNumber");

                            b1.HasKey("UserId");

                            b1.HasIndex("PhoneNumber")
                                .IsUnique();

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Email");

                    b.Navigation("Name");

                    b.Navigation("NIF");

                    b.Navigation("Password");

                    b.Navigation("PhoneNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
