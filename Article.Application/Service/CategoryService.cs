using Article.Data.Repository;
using Article.Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Article.Application.Service;
public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _context;

    public CategoryService(ICategoryRepository context)
    {
        _context = context;
    }

    public void Create(Category category)
    {
        Context.Add(category);
        Save();
    }

    public void Delete(int id)
    {
        Context.Remove(GetById(id));
        Save();
    }

    public void Update(Category category)
    {
        Context.Update(category);
        Save();
    }

    public Category GetById(int id)
        => Context.SingleOrDefault(cat => cat.CategoryId == id) ?? throw new InvalidOperationException();


    private DbSet<Category> Context
        => _context.GetContext();


    private void Save()
    {
        _context.Save();
    }
}