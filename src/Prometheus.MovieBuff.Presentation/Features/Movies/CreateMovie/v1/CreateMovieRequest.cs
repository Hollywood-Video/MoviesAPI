namespace Prometheus.MovieBuff.Presentation.Features.Movies.CreateMovie.v1;

// consider using a class with data annotations for validation
public record CreateMovieRequest(string Title, int YearOfRelease, IEnumerable<string> Genres);