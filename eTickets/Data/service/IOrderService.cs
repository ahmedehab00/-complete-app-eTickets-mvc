using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.service
{
    public interface IOrderService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> item, string userId, string userEmailAddress);

        Task<List<Order>>GetOrderByUserIdAndRoleAsync(string userId, string userRole);
    }
}
