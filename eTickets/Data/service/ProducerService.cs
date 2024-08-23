using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.service
{
    public class ProducerService:EntityBaseRepository<Producer>,IProducerService
    {
        public ProducerService(AppDbContext context):base(context)
        {
        }
        
    }
}
