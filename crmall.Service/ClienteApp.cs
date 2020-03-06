using crmall.Domain;

namespace crmall.Service
{
    public class ClienteApp
    {
        public ClienteViewModel Salvar(ClienteViewModel clienteView)
        {
            ClienteModel clienteModel = SetClienteModel(clienteView);

            //TODO - Mostrar exception caso validação falhe ou continuar com fluxo
            if (RegistroValido(clienteModel))
            {

            }

            return clienteView;
        }

        public ClienteModel SetClienteModel(ClienteViewModel clienteView)
        {
            return new ClienteModel
            {
                Id = clienteView.Id,
                Nome = clienteView.Nome,
                Genero = clienteView.Genero,
                DataNascimento = clienteView.DataNascimento
            };
        }

        public bool RegistroValido(ClienteModel cliente)
        {
            bool clienteValido = true;

            if (cliente.Nome.TrimEnd() == null || cliente.Genero.ToString().TrimEnd() == null || cliente.DataNascimento.ToString().TrimEnd() == null)
                return false;

            return clienteValido;
        }
    }
}
