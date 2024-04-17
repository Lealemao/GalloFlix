using GalloFlix.Models;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }

    //FluentAPI
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Configurando o Muitos para Muitos do MovieGenre
        //Chave primária composta.
        builder.Entity<MovieGenre>().HasKey(
            mg => new { mg.MovieId, mg.GenreId}
        );
        //Chave Estrangeira do Movie.
        builder.Entity<MovieGenre>()
            .HasOne(mg => mg.Movie)
            .WithMany(m => m.Genres)
            .HasForeignKey(mg => mg.MovieId);
        //Chave Estrangeira do Genre.
        builder.Entity<MovieGenre>()
            .HasOne(mg => mg.Genre)
            .WithMany(g => g.Movies)
            .HasForeignKey(mg => mg.GenreId);

        #endregion

    }
}