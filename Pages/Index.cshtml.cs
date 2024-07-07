// Pages/Index.cshtml.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ListOfMovies3.Services;
using Razor_Pages_ListOfMovies3.Models;

namespace Razor_Pages_ListOfMovies3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Films _movieService;

        public string Message { get; }
        public List<Movie> Movies => _movieService.Movies;

        public IndexModel(Films movieService)
        {
            _movieService = movieService;
            Message = "Hello!";
        }
        public string PrintTime() => DateTime.Now.ToShortTimeString();
        public void OnGet()
        {   }       
    }
}
