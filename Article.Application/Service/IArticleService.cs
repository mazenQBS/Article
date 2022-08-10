namespace Article.Application.Service;
using Domain.Entity;
public interface IArticleService
{
    void Create(Article article);
    void Delete(int id);
    void Update(Article article);
    Article GetById(int id);


}