using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerce.Dominio.Entidades;

namespace ECommerce.Dominio.Repositorios
{
    public interface IOrderRepository
    {
        Task<Pedido?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Pedido>> ObterTodosAsync();
        Task AdicionarAsync(Pedido pedido);
        Task AtualizarAsync(Pedido pedido);
        Task RemoverAsync(Pedido pedido);
    }
}
