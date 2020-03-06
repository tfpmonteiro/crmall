using crmall.Domain;
using Dapper.FluentMap.Dommel.Mapping;

namespace crmall.Repository
{
    public class EnderecoMap : DommelEntityMap<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");
            Map(col => col.Id).ToColumn("IdEndereco").IsKey();
        }
    }
}
