using crmall.Domain;
using Dapper.FluentMap.Dommel.Mapping;

namespace crmall.Repository
{
    public class ClienteMap : DommelEntityMap<ClienteModel>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            Map(col => col.Id).ToColumn("IdCliente").IsKey();
            Map(col => col.Endereco.Id).ToColumn("IdEndereco");
        }
    }
}
