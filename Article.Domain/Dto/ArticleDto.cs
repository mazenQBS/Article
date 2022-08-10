namespace Article.Domain.Dto;

public class ArticleDto
{
    public string? Title { get; set; }
    public string? Body { get; set; }
    public string? Data { get; set; }
    public bool IsActive { get; set; }
    public bool IsApproved { get; set; }
    public string? CategoryName { get; set; }
}