using Microsoft.EntityFrameworkCore;

namespace Movie.Models.DB
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {

        }
        public MovieContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<GenreMovie> GenreMovies { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();

            modelBuilder.Entity<Movie>()
                .HasIndex(m => m.Title)
                .IsUnique();
        }

        public class DbInitializer
        {
            private readonly ModelBuilder modelBuilder;
            public DbInitializer(ModelBuilder modelBuilder)
            {
                this.modelBuilder = modelBuilder;
            }
            public void Seed()
            {
                modelBuilder.Entity<Director>().HasData(new Director
                {
                    Id = 1,
                    Name = "John",
                });
                modelBuilder.Entity<Actor>().HasData(new Actor
                {
                    Id = 1,
                    Name = "Michael"
                });
                modelBuilder.Entity<Genre>().HasData(new Genre
                {
                    Id = 1,
                    Name = "Drama"
                });
                modelBuilder.Entity<Movie>().HasData(new Movie
                {
                    Id = 1,
                    DirectorId = 1,
                    Title = "Inception",
                    ReleaseDate = DateTime.Now
                });
                modelBuilder.Entity<ActorMovie>().HasData(new ActorMovie
                {
                    ActorId = 1,
                    MovieId = 1,
                    ActorMovieId = 1
                });
                modelBuilder.Entity<GenreMovie>().HasData(new GenreMovie
                {
                    GenreId = 1,
                    MovieId = 1,
                    GenreMovieId = 1
                });
                modelBuilder.Entity<Award>().HasData(new Award
                {
                    Id = 1,
                    Name = "Best Cinema",
                    MovieId = 1
                });
                modelBuilder.Entity<Review>().HasData(new Review
                {
                    Id = 1,
                    MovieId = 1,
                    Rating = 4,
                    Text = "Nice moview"
                });
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=Movie;Integrated Security=True");
        }
    }
}
