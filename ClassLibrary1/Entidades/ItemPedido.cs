using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Dominio.Entidades
{
    public class ItemPedido
    {
        public Guid ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }

        public ItemPedido(Guid produtoId, int quantidade, decimal precoUnitario)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        public decimal Total => Quantidade * PrecoUnitario;
    }

}