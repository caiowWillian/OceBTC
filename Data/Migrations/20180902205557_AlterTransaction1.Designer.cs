﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(OceannicContext))]
    [Migration("20180902205557_AlterTransaction1")]
    partial class AlterTransaction1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Domain.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("Domain.Models.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("BankId");

                    b.Property<int?>("CurrencyId");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int>("UserId");

                    b.Property<string>("UserWallet");

                    b.Property<double>("Value");

                    b.Property<int?>("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletId");

                    b.ToTable("Deposit");
                });

            modelBuilder.Entity("Domain.Models.ImgUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("Deletado");

                    b.Property<string>("FileContentBase64");

                    b.Property<long>("FileLenght");

                    b.Property<string>("FileName");

                    b.Property<int>("IdNews");

                    b.Property<string>("MimeType");

                    b.HasKey("Id");

                    b.ToTable("ImgUser");
                });

            modelBuilder.Entity("Domain.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<int?>("TransactionRelationId");

                    b.Property<int>("TransactionTypeId");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int>("UserId");

                    b.Property<double>("Value");

                    b.Property<double>("VariationDown");

                    b.Property<double>("VariationUp");

                    b.Property<bool>("WithVariation");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("TransactionRelationId");

                    b.HasIndex("TransactionTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Domain.Models.TransactionAlter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrencyId");

                    b.Property<bool>("Make");

                    b.Property<int?>("TransactionId");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("TransactionId");

                    b.ToTable("TransactionAlter");
                });

            modelBuilder.Entity("Domain.Models.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("Domain.Models.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account");

                    b.Property<string>("Agency");

                    b.Property<bool>("Ativo");

                    b.Property<int?>("CurrencyId");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int?>("UserBanksId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserWallet");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UserBanksId");

                    b.HasIndex("UserId");

                    b.ToTable("Transfer");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin");

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Describe");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int?>("ImgUserId");

                    b.Property<DateTime>("InputDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Pw")
                        .IsRequired();

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("ImgUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.Models.UserBanks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("UserBanks");
                });

            modelBuilder.Entity("Domain.Models.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Describe");

                    b.Property<string>("Guid");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Wallet");
                });

            modelBuilder.Entity("Domain.Models.Deposit", b =>
                {
                    b.HasOne("Domain.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId");
                });

            modelBuilder.Entity("Domain.Models.Transaction", b =>
                {
                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Transaction", "TransactionRelation")
                        .WithMany()
                        .HasForeignKey("TransactionRelationId");

                    b.HasOne("Domain.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.TransactionAlter", b =>
                {
                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Transaction")
                        .WithMany("TransactionAlter")
                        .HasForeignKey("TransactionId");
                });

            modelBuilder.Entity("Domain.Models.Transfer", b =>
                {
                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Domain.Models.UserBanks", "UserBanks")
                        .WithMany()
                        .HasForeignKey("UserBanksId");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.HasOne("Domain.Models.ImgUser", "ImgUser")
                        .WithMany()
                        .HasForeignKey("ImgUserId");
                });

            modelBuilder.Entity("Domain.Models.Wallet", b =>
                {
                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}