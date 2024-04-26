﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace kaufer_comex.Models
{
    [Table("Documentos")]
    public class Documento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Certificado de origem (*)")]
        [Required(ErrorMessage = "Obrigatório informar certificado origem")]
        public string CertificadoOrigem { get; set; }

        [Display(Name = "Certificado do Seguro (*)")]
        [Required(ErrorMessage = "Obrigatório informar certificado seguro")]
        public string CertificadoSeguro { get; set; }

        [Display(Name = "Envio do Certificado de origem (*)")]
        [Required(ErrorMessage = "Obrigatório informar a data")]

        public DateTime DataEnvioOrigem { get; set; }

        [Display(Name = "Envio do Certificado do seguro: (*)")]
        [Required(ErrorMessage = "Obrigatório informar a data")]

        public DateTime DataEnvioSeguro { get; set; }

        [Display(Name = "Tracking: (*)")]
        [Required(ErrorMessage = "Obrigatório informar certificado tracking")]
        public string TrackinCourier { get; set; }

        [Display(Name = "Processo: (*)")]
        [Required(ErrorMessage = "Obrigatório informar o código.")]
        public int ProcessoId { get; set; }
        [ForeignKey("ProcessoId")]
        public Processo Processo { get; set; }
    }
}
