namespace OO4.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public MovieType MovieType { get; set; }

        public Movie(string title, MovieType movieType)
        {
            Title = title;
            MovieType = movieType;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Type: {MovieType}";
        }
    }
}
