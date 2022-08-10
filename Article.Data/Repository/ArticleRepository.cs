using Microsoft.EntityFrameworkCore;

namespace Article.Data.Repository;

using Domain.Entity;
public class ArticleRepository: IArticleRepository
{
    private readonly ArticleDbContext _context;
    

    public ArticleRepository(ArticleDbContext context)
    {
        _context = context;


    }

    public DbSet<Article> GetContext
        =>_context.Articles;

    public void Save()
    {
        _context.SaveChanges();
    }

    
    }