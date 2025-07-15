using ProjetoGeanBagattoli.Enums;

namespace ProjetoGeanBagattoli.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public UF Estado { get; set; }
        public string CEP { get; set; }
    }
}
