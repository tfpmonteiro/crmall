using System;

namespace crmall.Domain
{
    public class ClienteModel
    {
        public decimal Id { get; set; }
        public string Nome { get; set; }
        public EnumGenero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

    }
}
