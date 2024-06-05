﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace kaufer_comex.Models
{

    [Table("Processo")]
    public class Processo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Código  (*)")]
        [Required(ErrorMessage = "Obrigatório informar o código de exportação.")]
        public string CodProcessoExportacao { get; set; }

        [Display(Name = "Exportador (*)")]
        [Required(ErrorMessage = "Obrigatório informar o código do exportador.")]
        public int ExportadorId { get; set; }

        [Display(Name = "Importador (*)")]
        [Required(ErrorMessage = "Obrigatório informar o código do importador.")]
        public int ImportadorId { get; set; }

        [Display(Name = "Modal (*)")]
        public Modal Modal { get; set; }

        [Display(Name = "Incoterm (*)")]
        public Incoterm Incoterm { get; set; }

        [Display(Name = "Destino (*)")]
        public int DestinoId { get; set; }

        [ForeignKey("DestinoId")]
        public Destino Destino { get; set; }

        [Display(Name = "Responsável (*)")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Display(Name = "Fronteira (*)")]
        public int FronteiraId { get; set; }

        [ForeignKey("FronteiraId")]
        public Fronteira Fronteira { get; set; }

        [Display(Name = "Despachante (*)")]
        public int DespachanteId { get; set; }

        [ForeignKey("DespachanteId")]
        public Despachante Despachante { get; set; }

        [Display(Name = "Vendedor (*)")]
        public int VendedorId { get; set; }

        [ForeignKey("VendedorId")]
        public Vendedor Vendedor { get; set; }

        [Display(Name = "Status (*)")]
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }

        [Display(Name = "Proforma(*)")]
        public string Proforma { get; set; }

        [Display(Name = "Data de Início do Processo (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataInicioProcesso { get; set; }

        [Display(Name = "Previsão de produção (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime PrevisaoProducao { get; set; }

        [Display(Name = "Previsão de pagamento (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime PrevisaoPagamento { get; set; }

        [Display(Name = "Previsão Coleta (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime PrevisaoColeta { get; set; }

        [Display(Name = "Previsão Cruze (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime PrevisaoCruze { get; set; }

        [Display(Name = "Previsão de entrega (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime PrevisaoEntrega { get; set; }

        [Display(Name = "Observações (*)")]
        public string Observacoes { get; set; }

        [Display(Name = "Pedidos Relacionados (*)")]
        public string PedidosRelacionados { get; set; }

        public virtual EmbarqueRodoviario EmbarqueRodoviario { get; set; }

        public virtual Despacho Despacho { get; set; }

        public virtual Documento Documento { get; set; }

        public virtual ValorProcesso ValorProcesso { get; set; }

        public virtual List<Veiculo> Veiculos { get; set; }

        public virtual ICollection<DCE> DCES { get; set; }

        public virtual ICollection<ProcessoExpImp> ExpImps { get; set; }



    }

    public enum Modal
    {
        [Display(Name = "Rodoviário")]
        Rodoviario,
        [Display(Name = "Aéreo")]
        Aereo,
        [Display(Name = "Marítimo")]
        Maritimo
    }

    public enum Incoterm
    {
        CFR,
        CIF,
        CIP,
        CPT,
        DAP,
        DAT,
        DDP,
        EXW,
        FAS,
        FCA,
        FOB
    }
}
