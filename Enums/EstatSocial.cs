using System.ComponentModel.DataAnnotations;

namespace ProjetoGeanBagattoli.Enums
{
        public enum EstatSocial
        {
        [Display(Name = "Solteiro")]
        Solteiro,
        [Display(Name = "União Estável")]
        UniaoEstavel,
        [Display(Name = "Casado")]
        Casado,
        [Display(Name = "Divorciado")]
        Divorciado
        }
    
}

