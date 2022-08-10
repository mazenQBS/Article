using Microsoft.EntityFrameworkCore;

namespace Article.Data.Repository;
using Domain.Entity;
public interface IArticleRepository
{
    public DbSet<Article> GetContext { get; }

    public void Save();

   
    //IEnumerable<Article> GetAllArticle { get; }
}