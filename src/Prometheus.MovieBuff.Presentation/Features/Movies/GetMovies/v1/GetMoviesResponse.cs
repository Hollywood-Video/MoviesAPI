namespace Prometheus.MovieBuff.Presentation.Features.Movies.GetMovies.v1;

internal sealed record GetMoviesResponse(IEnumerable<MovieDto> Movies);