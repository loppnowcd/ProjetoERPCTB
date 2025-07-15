using System.ComponentModel.DataAnnotations;

namespace ProjetoGeanBagattoli.Models
{
    public class PessoaF
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DadosEndereco Naturalidade { get; set; }
        public DadosFiliacao Filiacao { get; set; }
        public DadosDocumentos Documento { get; set; }
        public string Profissao { get; set; }
        public DadosEstadoCivil EstadoCivil { get; set; }
        public DadosEndereco Endereco { get; set; }
        public DadosContato Contato { get; set; }
        public bool Status { get; set; }

    }
}