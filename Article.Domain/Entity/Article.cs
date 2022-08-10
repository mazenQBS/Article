namespace Article.Domain.Entity;

public class Article
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Data { get; set; }
    public bool IsActive { get; set; }
    public bool IsApproved { get; set; }
    public Category Category { get; set; }
}