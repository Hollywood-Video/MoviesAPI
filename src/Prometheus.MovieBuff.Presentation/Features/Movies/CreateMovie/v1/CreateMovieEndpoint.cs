namespace Prometheus.MovieBuff.Presentation.Features.Movies.CreateMovie.v1;

internal static class CreateMovieEndpoint
{
    internal static IEndpointRouteBuilder MapCreateMovieEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/movies", async (CreateMovieRequest request, CancellationToken cancellationToken = default) =>
        {
            var id = Guid.NewGuid();
            var result = new { id = id };
            // TODO => return Results.CreatedAtRoute("", )
            return Results.Created($"/movies/{id}", result);
        })
        .WithName("CreateMovie")
        .WithTags("Movies");

        return app;
    }
}