namespace ProjetoGeanBagattoli.Models
{
    public class PessoaF
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadCivil EstadoCivil { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

    }
}