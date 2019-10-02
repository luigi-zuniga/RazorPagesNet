using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovies.Data
{
    /// DOC-COMMENTS-TAGS
    /// <summary>
    /// DbSetpropiedad para el conjunto de entidades
    /// </summary>
    /// <remarks>
    /// Una Instancia DbContext representa una sesion con la base de datos y que puede
    /// ser usada por QUERY y GUARDAS INSTANCIAS de una Entidad.
    /// </remarks>
    /// <example>
    /// En la terminología de Entity Framework, un conjunto de entidades generalmente corresponde a una tabla de base de datos
    /// </example>

    public class RazorPagesMovieContext : DbContext
    {

        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
        : base(options)
        {
        }
        
        public DbSet<RazorPagesMovies.Models.Movie> Movie { get; set; }
    }
}

