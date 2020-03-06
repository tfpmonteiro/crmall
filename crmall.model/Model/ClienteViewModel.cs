using System;
using System.ComponentModel.DataAnnotations;

namespace crmall.Domain
{
    public class ClienteViewModel
    {
        public decimal Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public EnumGenero Genero { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int EnderecoNumero { get; set; }
        public string Complemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

    }
}
