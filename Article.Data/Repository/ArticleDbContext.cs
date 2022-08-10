using Microsoft.EntityFrameworkCore;

namespace Article.Data.Repository;
using Domain.Entity;

public class ArticleDbContext : DbContext
{
    public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }



}
