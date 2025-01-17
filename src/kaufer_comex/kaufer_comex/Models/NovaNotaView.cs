﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kaufer_comex.Models
{
    public class NovaNotaView
    {

        [Display(Name = "Número Nf (*)")]
        [Required(ErrorMessage = "Obrigatório informar o número da NF.")]
        public int? NumeroNf { get; set; }

        [Display(Name = "Emissão (*)")]
        [Required(ErrorMessage = "Obrigatório informar a data de emissão.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime Emissao { get; set; }

        [Display(Name = "Base Nota (*)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Obrigatório informar a data.")]
        public DateTime BaseNota { get; set; }

        [Display(Name = "Valor Fob (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Obrigatório informar o Valor Fob.")]
        public decimal? ValorFob { get; set; }

        [Display(Name = "Valor Frete (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Obrigatório informar o valor do frete.")]
        public decimal? ValorFrete { get; set; }

        [Display(Name = "Valor Seguro (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Obrigatório informar o valor do seguro.")]
        public decimal? ValorSeguro { get; set; }

        [Display(Name = "Valor Cif (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Obrigatório informar o valor Cif.")]
        public decimal? ValorCif { get; set; }

        [Display(Name = "Peso Liq (*)")]
        [Required(ErrorMessage = "Obrigatório informar o peso líquido.")]
        public float? PesoLiq { get; set; }

        [Display(Name = "Peso Bruto (*)")]
        [Required(ErrorMessage = "Obrigatório informar o peso bruto.")]
        public float? PesoBruto { get; set; }

        [Display(Name = "Taxa Cambial (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? TaxaCambial { get; set; }

        [Display(Name = "Certificado Qualidade (*)")]
        public string CertificadoQualidade { get; set; }

        [Display(Name = "Embarque Rodoviário (*)")]
        public int EmbarqueRodoviarioId { get; set; }

        [ForeignKey("EmbarqueRodoviarioId")]
        public EmbarqueRodoviario EmbarqueRodoviario { get; set; }

        [Display(Name = "Veículo (*)")]
        [Required(ErrorMessage = "Obrigatório selecionar um veículo.")]
        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }

        [Display(Name = "Valor Total (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? ValorTotalNota { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        public Nota Nota { get; set; }

        public NotaItem NotaItem { get; set; }

        public NotaItemTemp NotaItemTemp { get; set; }

        public AdicionaItemView AdicionaItem { get; set; }

        [Display(Name = "Quantidade Total (*)")]
        public double QuantidadeTotal { get { return NotaItemTemps == null ? 0 : NotaItemTemps.Sum(d => d.Quantidade); } }

        [Display(Name = "Quantidade Total (*)")]
        public double QuantidadeTotalNota { get; set; }

        [Display(Name = "Valor Total (*)")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? ValorTotal { get { return NotaItemTemps == null ? 0 : NotaItemTemps.Sum(d => d.Valor); } }

        public List<NotaItem> NotaItens { get; set; }

        public List<NotaItemTemp> NotaItemTemps { get; set; }

        public List<Nota> Notas { get; set; }

        public List<AdicionaItemView> Itens { get; set; }

    }
}
