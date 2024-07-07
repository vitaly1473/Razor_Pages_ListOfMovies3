// Pages/MovieDetails.cshtml.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages_ListOfMovies3.Services;
using Razor_Pages_ListOfMovies3.Models; 

namespace Razor_Pages_ListOfMovies3.Pages
{
    public class MovieDetailsModel : PageModel
    {
        private readonly Films film_;

        public Movie  Movie { get; set; }

        public MovieDetailsModel(Films film)
        {
            film_ = film;
        }
        public void OnGet(int id)
        {
            Movie = film_.GetMovieById(id);
        }
    }
}
