using System.ComponentModel.DataAnnotations;

namespace ProjetoGeanBagattoli.Models
{
    public class DadosDocumentos
    {
        public string CPF { get; set; }

        public string RG { get; set; }
        [Display(Name = "Data de Expedição do RG")]

        public DateTime RGExpedido { get; set; }

        public string CNH { get; set; }

        [Display(Name = "Data de Expedição da CNH")]
        public DateTime CNHExpedido { get; set; }

        [Display(Name = "Titulo de Eleitor")]
        public string TituloEleitor { get; set; }

        [Display(Name = "Numero do PIS")]
        public string PisNumero { get; set; }
    }
}
