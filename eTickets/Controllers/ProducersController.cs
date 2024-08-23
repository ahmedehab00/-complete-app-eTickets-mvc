using eTickets.Data;
using eTickets.Data.service;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZendeskApi_v2.Models.Constants;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducerService _service;
        public ProducersController(IProducerService service)
        {
           _service=service;
        }

        [AllowAnonymous]
        public async Task< IActionResult > Index()
        {
            var allProducers= await _service.GetAllAsync();
            return View(allProducers);
        }
        //Get: Producers/Details/1
        [AllowAnonymous]

        public async Task<IActionResult> DetailsAsync(int id)
        {
            var ProducerDetails = await _service.GetByIdAsync(id);
            if (ProducerDetails == null)
            {
                return View("Not Found");
            }
            return View(ProducerDetails);
        }
        // Get:Producers/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")]Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);    
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        // Get:Producers/Edit
        public async Task <IActionResult> Edit(int id)
        {
            var ProducerDetails= await _service.GetByIdAsync(id);
            if (ProducerDetails == null) return View("Not Found");  
            return View(ProducerDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("id,FullName,ProfilePictureUrl,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            if (id == producer.id)
            {
                await _service.UpdateAsync(id,producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        // Get:Producers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var ProducerDetails = await _service.GetByIdAsync(id);
            if (ProducerDetails == null) return View("Not Found");
            return View(ProducerDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ProducerDetails = await _service.GetByIdAsync(id);
            if (ProducerDetails == null) return View("Not Found");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
