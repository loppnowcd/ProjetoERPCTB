using System.ComponentModel.DataAnnotations;

namespace ProjetoGeanBagattoli.Models
{
    public class DadosFiliacao
    {
        [Display(Name = "Filiação - Nome do Pai")]
        public string NomePai { get; set; }

        [Display(Name = "Filiação - Nome da Mãe")]
        public string NomeMae { get; set; }
    }
}
