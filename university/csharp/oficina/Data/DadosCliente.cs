using Oficina.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Oficina.Data
{
    public class DadosCliente
    {
        public List<Cliente> Listar()
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                return bd.Clientes.OrderBy(c => c.Nome).ToList();
            }
        }

        public List<Cliente> Pesquisar(string texto)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                return bd.Clientes
                    .Where(c => c.Nome.Contains(texto)
                             || (c.Telefone != null && c.Telefone.Contains(texto))
                             || (c.Email != null && c.Email.Contains(texto))
                             || (c.NIF != null && c.NIF.Contains(texto)))
                    .OrderBy(c => c.Nome)
                    .ToList();
            }
        }

        public void Inserir(Cliente cliente)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                bd.Clientes.Add(cliente);
                bd.SaveChanges();
            }
        }

        public void Atualizar(Cliente cliente)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                Cliente existente = bd.Clientes.Find(cliente.Id);
                if (existente == null)
                {
                    throw new InvalidOperationException("Cliente não encontrado.");
                }

                existente.Nome = cliente.Nome;
                existente.Telefone = cliente.Telefone;
                existente.Email = cliente.Email;
                existente.NIF = cliente.NIF;
                bd.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            using (OficinaEntities bd = new OficinaEntities())
            {
                Cliente cliente = bd.Clientes.Find(id);
                if (cliente == null)
                {
                    throw new InvalidOperationException("Cliente não encontrado.");
                }

                bd.Clientes.Remove(cliente);
                bd.SaveChanges();
            }
        }
    }
}
