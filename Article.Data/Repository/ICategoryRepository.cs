using Article.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Article.Data.Repository;
public interface ICategoryRepository
{
    public DbSet<Category> GetContext();

    public void Save();
    

}