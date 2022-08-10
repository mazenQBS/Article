using Article.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Article.Application.Service;
using Domain.Entity;
public class ArticleService : IArticleService
{
    private readonly IArticleRepository _context;

    public ArticleService(IArticleRepository context)
    {
        _context = context;

    }
    public void Create(Article article)
    {
        Context.Add(article);
        Save();
    }


    public void Delete(int id)
    {
        Context.Remove(GetById(id));
        Save();
    }

    public void Update(Article article)
    {
        Context.Update(article);
        Save();
    }

    public Article GetById(int id)
        => Context.Include(c => c.Category).SingleOrDefault(a => a.ArticleId == id) ?? throw new InvalidOperationException();

    private DbSet<Article> Context
        => _context.GetContext;

    private void Save()
    {
        _context.Save();
    }
}