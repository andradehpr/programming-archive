using Oficina.Data;
using Oficina.Model;
using System.Collections.Generic;

namespace Oficina.Controllers
{
    public class ClienteController
    {
        private DadosCliente clienteData = new DadosCliente();

        public List<Cliente> ListarClientes()
        {
            return clienteData.Listar();
        }

        public void InserirCliente(Cliente cliente)
        {
            clienteData.Inserir(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            clienteData.Atualizar(cliente);
        }

        public void ApagarCliente(int id)
        {
            clienteData.Apagar(id);
        }

        public List<Cliente> PesquisarClientes(string texto)
        {
            return clienteData.Pesquisar(texto);
        }
    }
}
