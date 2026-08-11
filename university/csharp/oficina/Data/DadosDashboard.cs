using Oficina.Model;
using System.Collections.Generic;
using System.Linq;

namespace Oficina.Data
{
    public class DadosDashboard
    {
        // Valores dos cartões do dashboard (Início).
        public (int TotalClientes, int FolhasAbertas, int EmReparacao, int Concluidas) ObterResumo()
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                return (
                    bd.Clientes.Count(),
                    bd.FolhasObra.Count(f => f.Estado == "Aberta"),
                    bd.FolhasObra.Count(f => f.Estado == "Em Reparação"),
                    bd.FolhasObra.Count(f => f.Estado == "Concluída")
                );
            }
        }

        // Últimas folhas de obra criadas.
        public List<FolhaObra> ObterUltimasEntradas(int quantidade)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                return bd.FolhasObra
                    .Include("Cliente")
                    .OrderByDescending(f => f.DataEntrada)
                    .ThenByDescending(f => f.Id)
                    .Take(quantidade)
                    .ToList()
                    .Select(f =>
                    {
                        f.NomeCliente = f.Cliente != null ? f.Cliente.Nome : "";
                        return f;
                    })
                    .ToList();
            }
        }
    }
}
