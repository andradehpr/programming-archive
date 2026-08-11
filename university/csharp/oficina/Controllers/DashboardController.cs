using Oficina.Data;
using Oficina.Model;
using System.Collections.Generic;

namespace Oficina.Controllers
{
    public class DashboardController
    {
        private DadosDashboard dashboardData = new DadosDashboard();

        public (int TotalClientes, int FolhasAbertas, int EmReparacao, int Concluidas) ObterResumo()
        {
            return dashboardData.ObterResumo();
        }

        public List<FolhaObra> ObterUltimasEntradas(int quantidade = 8)
        {
            return dashboardData.ObterUltimasEntradas(quantidade);
        }
    }
}
