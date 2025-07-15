using ProjetoGeanBagattoli.Enums;

namespace ProjetoGeanBagattoli.Models
{
    public class EstadCivil
    {
        public int Id { get; set; }
        public EstatSocial EstatusSocial { get; set; }
        public string? NomeConjuge { get; set; }
        public RegimCasamento? RegimeCasamento { get; set; }
    }
}
