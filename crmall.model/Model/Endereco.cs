namespace crmall.Domain
{
    public class Endereco
    {
        public decimal Id { get; set; }
        public string RuaAv { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
