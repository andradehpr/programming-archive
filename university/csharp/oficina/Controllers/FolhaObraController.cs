using Oficina.Data;
using Oficina.Model;
using System.Collections.Generic;

namespace Oficina.Controllers
{
    public class FolhaObraController
    {
        private DadosFolhaObra folhaObraData = new DadosFolhaObra();

        public List<FolhaObra> ListarFolhasObra()
        {
            return folhaObraData.Listar();
        }

        public void InserirFolhaObra(FolhaObra folha)
        {
            folhaObraData.Inserir(folha);
        }

        public void AtualizarFolhaObra(FolhaObra folha)
        {
            folhaObraData.Atualizar(folha);
        }

        public void ApagarFolhaObra(int id)
        {
            folhaObraData.Apagar(id);
        }

        public List<FolhaObra> PesquisarFolhasObra(string texto)
        {
            return folhaObraData.Pesquisar(texto);
        }
    }
}
