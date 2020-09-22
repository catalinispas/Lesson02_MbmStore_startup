using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Book> books;
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;

            IEnumerable<MusicCD> musicCDs;
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.MusicCDs = musicCDs;

            IEnumerable<Movie> movies;
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Movies = movies;

            return View();
        }
    }
}
