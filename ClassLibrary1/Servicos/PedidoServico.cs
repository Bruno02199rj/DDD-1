using ECommerce.Dominio.Entidades;
using ECommerce.Dominio.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Dominio.Servicos
{
    public class PedidoServico
    {
        public void Finalizar(Pedido pedido)
        {
            if (!pedido.Itens.Any())
                throw new DomainException("Não é possível finalizar um pedido sem itens.");

            if (pedido.CalcularTotal() < 50)
                throw new DomainException("Valor mínimo para finalizar o pedido é R$ 50,00.");
        }
    }
}
