using Article.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Article.Data.Repository;
public class CategoryRepository:ICategoryRepository

{
    private readonly ArticleDbContext _context;


    public CategoryRepository(ArticleDbContext context)
    {
        _context = context;
    }

    public DbSet<Category> GetContext()
        => _context.Categories;

    public void Save()
    {
        _context.SaveChanges();
    }

    

    
}
