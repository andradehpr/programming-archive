using Oficina.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oficina.Data
{
    public class DadosFolhaObra
    {
        // Copia Cliente.Nome para NomeCliente para o binding {Binding NomeCliente} na grelha.
        private static FolhaObra MapearComNomeCliente(FolhaObra folha)
        {
            folha.NomeCliente = folha.Cliente != null ? folha.Cliente.Nome : "";
            return folha;
        }

        public List<FolhaObra> Listar()
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                return bd.FolhasObra
                    .Include("Cliente")
                    .OrderByDescending(f => f.DataEntrada)
                    .ToList()
                    .Select(MapearComNomeCliente)
                    .ToList();
            }
        }

        public List<FolhaObra> Pesquisar(string texto)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                return bd.FolhasObra
                    .Include("Cliente")
                    .Where(f => f.Matricula.Contains(texto)
                             || f.Cliente.Nome.Contains(texto)
                             || (f.Marca != null && f.Marca.Contains(texto))
                             || (f.Modelo != null && f.Modelo.Contains(texto)))
                    .OrderByDescending(f => f.DataEntrada)
                    .ToList()
                    .Select(MapearComNomeCliente)
                    .ToList();
            }
        }

        public void Inserir(FolhaObra folha)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                bd.FolhasObra.Add(folha);
                bd.SaveChanges();
            }
        }

        public void Atualizar(FolhaObra folha)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                FolhaObra existente = bd.FolhasObra.Find(folha.Id);
                if (existente == null)
                {
                    throw new InvalidOperationException("Folha de obra não encontrada.");
                }

                existente.ClienteId = folha.ClienteId;
                existente.DataEntrada = folha.DataEntrada;
                existente.Matricula = folha.Matricula;
                existente.Marca = folha.Marca;
                existente.Modelo = folha.Modelo;
                existente.Km = folha.Km;
                existente.ProblemaDescrito = folha.ProblemaDescrito;
                existente.ServicosRealizados = folha.ServicosRealizados;
                existente.Estado = folha.Estado;
                existente.ValorTotal = folha.ValorTotal;
                bd.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                FolhaObra folha = bd.FolhasObra.Find(id);
                if (folha == null)
                {
                    throw new InvalidOperationException("Folha de obra não encontrada.");
                }

                bd.FolhasObra.Remove(folha);
                bd.SaveChanges();
            }
        }
    }
}
