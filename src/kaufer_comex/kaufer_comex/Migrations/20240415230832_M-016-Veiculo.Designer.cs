﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kaufer_comex.Models;

#nullable disable

namespace kaufer_comex.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240415230832_M-016-Veiculo")]
    partial class M016Veiculo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("kaufer_comex.Models.AgenteDeCarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeAgenteCarga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AgenteDeCargas");
                });

            modelBuilder.Entity("kaufer_comex.Models.CadastroDespesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DCEId")
                        .HasColumnType("int");

                    b.Property<string>("NomeDespesa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DCEId");

                    b.ToTable("CadastroDespesa");
                });

            modelBuilder.Entity("kaufer_comex.Models.DCE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CadastroDespesaId")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.Despachante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeDespachante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Despachantes");
                });

            modelBuilder.Entity("kaufer_comex.Models.Despacho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CodPais")
                        .HasColumnType("int");

                    b.Property<string>("ConhecimentoEmbarque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAverbacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataConhecimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExportacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroDue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parametrizacao")
                        .HasColumnType("int");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("Despacho");
                });

            modelBuilder.Entity("kaufer_comex.Models.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Destino");
                });

            modelBuilder.Entity("kaufer_comex.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CertificadoOrigem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoSeguro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataEnvioOrigem")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEnvioSeguro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<string>("TrackinCourier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("kaufer_comex.Models.EmbarqueRodoviario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgenteDeCargaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChegadaDestino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmbarque")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProcesso")
                        .HasColumnType("int");

                    b.Property<int?>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<string>("TransitTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transportadora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgenteDeCargaId");

                    b.HasIndex("ProcessoId");

                    b.ToTable("EmbarqueRodoviario");
                });

            modelBuilder.Entity("kaufer_comex.Models.ExpImp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoExpImp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ExpImp");
                });

            modelBuilder.Entity("kaufer_comex.Models.FornecedorServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DCEId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoServico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DCEId");

                    b.ToTable("FornecedorServico");
                });

            modelBuilder.Entity("kaufer_comex.Models.Fronteira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeFronteira")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fronteiras");
                });

            modelBuilder.Entity("kaufer_comex.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgenteDeCargaId")
                        .HasColumnType("int");

                    b.Property<string>("CodProcessoExportacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataInicioProcesso")
                        .HasColumnType("datetime2");

                    b.Property<int>("DespachanteId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<int>("ExportadorId")
                        .HasColumnType("int");

                    b.Property<int>("FronteiraId")
                        .HasColumnType("int");

                    b.Property<int>("ImportadorId")
                        .HasColumnType("int");

                    b.Property<int>("Incoterm")
                        .HasColumnType("int");

                    b.Property<int>("Modal")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedidosRelacionados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PrevisaoColeta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoCruze")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoPagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoProducao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Proforma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgenteDeCargaId");

                    b.HasIndex("DespachanteId");

                    b.HasIndex("DestinoId");

                    b.HasIndex("FronteiraId");

                    b.HasIndex("StatusId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.ProcessoExpImp", b =>
                {
                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int>("ExpImpId")
                        .HasColumnType("int");

                    b.HasKey("ProcessoId", "ExpImpId");

                    b.HasIndex("ExpImpId");

                    b.ToTable("Processo-Exportador-Importador");
                });

            modelBuilder.Entity("kaufer_comex.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StatusAtual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("kaufer_comex.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("kaufer_comex.Models.UsuarioProcesso", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "ProcessoId");

                    b.HasIndex("ProcessoId");

                    b.ToTable("UsuarioProcessos");
                });

            modelBuilder.Entity("kaufer_comex.Models.ValorProcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("FreteInternacional")
                        .HasColumnType("real");

                    b.Property<int>("Moeda")
                        .HasColumnType("int");

                    b.Property<float>("SeguroInternaciona")
                        .HasColumnType("real");

                    b.Property<float>("ValorExw")
                        .HasColumnType("real");

                    b.Property<float>("ValorFobFca")
                        .HasColumnType("real");

                    b.Property<float>("ValorTotalCif")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ValorProcessos");
                });

            modelBuilder.Entity("kaufer_comex.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Motorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("kaufer_comex.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeVendedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("kaufer_comex.Models.CadastroDespesa", b =>
                {
                    b.HasOne("kaufer_comex.Models.DCE", "DCE")
                        .WithMany("CadastroDespesas")
                        .HasForeignKey("DCEId");

                    b.Navigation("DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.DCE", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany("DCES")
                        .HasForeignKey("ProcessoId");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.Despacho", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.Documento", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.EmbarqueRodoviario", b =>
                {
                    b.HasOne("kaufer_comex.Models.AgenteDeCarga", "AgenteDeCarga")
                        .WithMany()
                        .HasForeignKey("AgenteDeCargaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId");

                    b.Navigation("AgenteDeCarga");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.FornecedorServico", b =>
                {
                    b.HasOne("kaufer_comex.Models.DCE", "DCE")
                        .WithMany("FornecedorServicos")
                        .HasForeignKey("DCEId");

                    b.Navigation("DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.Processo", b =>
                {
                    b.HasOne("kaufer_comex.Models.AgenteDeCarga", "AgenteDeCarga")
                        .WithMany()
                        .HasForeignKey("AgenteDeCargaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Despachante", "Despachante")
                        .WithMany()
                        .HasForeignKey("DespachanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Destino", "Destino")
                        .WithMany("Processos")
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Fronteira", "Fronteira")
                        .WithMany()
                        .HasForeignKey("FronteiraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgenteDeCarga");

                    b.Navigation("Despachante");

                    b.Navigation("Destino");

                    b.Navigation("Fronteira");

                    b.Navigation("Status");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("kaufer_comex.Models.ProcessoExpImp", b =>
                {
                    b.HasOne("kaufer_comex.Models.ExpImp", "ExpImp")
                        .WithMany("ProcessoExpImps")
                        .HasForeignKey("ExpImpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany("ExpImps")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpImp");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.UsuarioProcesso", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany("ProcessosUsuarios")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Usuario", "Usuario")
                        .WithMany("UsuarioProcessos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("kaufer_comex.Models.DCE", b =>
                {
                    b.Navigation("CadastroDespesas");

                    b.Navigation("FornecedorServicos");
                });

            modelBuilder.Entity("kaufer_comex.Models.Destino", b =>
                {
                    b.Navigation("Processos");
                });

            modelBuilder.Entity("kaufer_comex.Models.ExpImp", b =>
                {
                    b.Navigation("ProcessoExpImps");
                });

            modelBuilder.Entity("kaufer_comex.Models.Processo", b =>
                {
                    b.Navigation("DCES");

                    b.Navigation("ExpImps");

                    b.Navigation("ProcessosUsuarios");
                });

            modelBuilder.Entity("kaufer_comex.Models.Usuario", b =>
                {
                    b.Navigation("UsuarioProcessos");
                });
#pragma warning restore 612, 618
        }
    }
}