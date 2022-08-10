using Article.Domain.Entity;

namespace Article.Application.Service;
public interface ICategoryService
{
    void Create(Category category);
    void Delete(int id);
    void Update(Category category);
    Category GetById(int id);


}