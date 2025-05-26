using ECommerce.Dominio.Entidades;
using ECommerce.Dominio.Repositorios;
using ECommerce.Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infraestrutura.Repositorios
{
    public class PedidoRepositorio : IOrderRepository
    {
        private readonly ECommerceDbContext _context;

        public PedidoRepositorio(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Pedido?> ObterPorIdAsync(Guid id)
        {
            return await _context.Pedidos
                //.Include(p => p.Itens) 
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Pedido>> ObterTodosAsync()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public async Task AdicionarAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverAsync(Pedido pedido)
        {
            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
        }
    }
}
