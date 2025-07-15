using ProjetoGeanBagattoli.Enums;

namespace ProjetoGeanBagattoli.Models
{
    public class DadosEstadoCivil
    {
        public EstatSocial EstatusSocial { get; set; }
        public string? NomeConjuge { get; set; }
        public RegimCasamento? RegimeCasamento { get; set; }
    }
}
