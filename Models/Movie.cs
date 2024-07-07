// Models/Movie.cs
// добавили в проект класс Movie

namespace Razor_Pages_ListOfMovies3.Models
{
    public class Movie
    {
        public int Id_ { get; set; } // id фильма
        public string Name_ { get; set; }
        public string Director_ { get; set; }
        public string Description_ { get; set; }
        public int Year_ { get; set; }

        // конструктор, принимающий четыре аргумента
        public Movie(int id, string name, string director, string description, int year)
        {
            Id_ = id;
            Name_ = name;
            Director_ = director;
            Description_ = description;
            Year_ = year;
        }
    }
}
