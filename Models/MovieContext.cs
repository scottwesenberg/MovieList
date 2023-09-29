using Microsoft.EntityFrameworkCore;
namespace MovieList.Models
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action"},
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" }

            );
          
            modelBuilder.Entity<Movie>().HasData(
                 new Movie
                 {
                     MovieId = 1,
                     Name = "Caddy Shack",
                     Year = 1980,
                     Rating = 4,
                     GenreId = "C"
                 },
                 new Movie
                 {
                     MovieId = 2,
                     Name = "Happy Gilmore",
                     Year = 1996,
                     Rating = 5,
                     GenreId = "A"

                 },
                new Movie
                {
                    MovieId = 3,
                    Name = "Caddy Shack 2",
                    Year = 1988,
                    Rating = 2,
                    GenreId = "D"
                }
             );

        }
    }
}
