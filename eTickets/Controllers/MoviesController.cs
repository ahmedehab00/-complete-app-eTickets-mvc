using eTickets.Data;
using eTickets.Data.service;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using ZendeskApi_v2.Models.Constants;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]

    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;

        }
        [AllowAnonymous]
        public async Task< IActionResult> Index()
        {
            var allMovies=await _service.GetAllAsync(n=>n.Cinema);
            return View(allMovies);
        }
        [AllowAnonymous]

        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allMovies.Where(n => string.Equals(n.name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }


            return View("Index", allMovies);
        }

        //Get:Movies/Details/id
        [AllowAnonymous]

        public async Task<IActionResult>Details(int id)
        {
            var MovieDetails=await _service.GetMovieByIdAsync(id);
            return View(MovieDetails);
        }
        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

                return View(movie);
            }
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        //GET: Movies/edit/1
        public async Task<IActionResult> Edit(int id)
        { 
            var MovieDetails= await _service.GetMovieByIdAsync(id);
            if (MovieDetails == null) return View("NotFound");

            var response = new NewMovieVM()
            {
                Id=MovieDetails.id,
                name=MovieDetails.name,
                description=MovieDetails.description,
                price=MovieDetails.price,
                StartDate=MovieDetails.StartDate,
                EndDate=MovieDetails.EndDate,
                ImageUrl=MovieDetails.ImageUrl,
                MovieCategory=MovieDetails.MovieCategory,
                CinemaId=MovieDetails.CinemaId,
                ProducerId=MovieDetails.ProducerId,
                ActorIds=MovieDetails.Actors_Movies.Select(n=>n.ActorId).ToList(),
            };  

            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

            return View(response); 
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if(id != movie.Id)
            {
                return View("NotFound");
            }


            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

                  ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "id", "Name");
                  ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "id", "FullName");
                  ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "id", "FullName");

                return View(movie);
            }
            await _service.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}


        