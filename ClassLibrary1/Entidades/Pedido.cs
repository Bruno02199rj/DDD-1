
using ECommerce.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Dominio.Entidades
{
    public class Pedido
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CriadoEm { get; private set; } = DateTime.UtcNow;
        public List<ItemPedido> Itens { get; private set; } = new();

        public void AdicionarItem(Guid produtoId, int quantidade, decimal precoUnitario)
        {
            if (quantidade <= 0)
                throw new DomainException("Quantidade inválida.");

            Itens.Add(new ItemPedido(produtoId, quantidade, precoUnitario));
        }

        public decimal CalcularTotal() => Itens.Sum(i => i.Total);
    }
}
