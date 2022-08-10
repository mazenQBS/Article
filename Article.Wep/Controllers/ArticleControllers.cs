using Article.Application.Service;
using Article.Application.Validator;
using Article.Data.Repository;
using Article.Domain.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;



namespace Article.Wep.Controllers;
using Domain.Entity;

[ApiController]
[Route("api/[Controller]/[action]")]
public class ArticleControllers : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IArticleService _articleService;
    
    public ArticleControllers(IArticleRepository articleRepository,IMapper mapper)
    {
        _mapper = mapper;
        _articleService = new ArticleService(articleRepository);
    }


    [HttpPost]
    public IActionResult Create(ArticleDto articleDto)
    {   
        if (!IsValid(articleDto)) return BadRequest();

        var article = _mapper.Map<Article>(articleDto);
        
        _articleService.Create(article);
        return Ok();
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var art = _articleService.GetById(id);
        if (art == null) return NotFound();

        _articleService.Delete(id);
        return Ok();
    }


    [HttpPatch]
    public IActionResult Update(ArticleDto articleDto)
    {
        if (!IsValid(articleDto)) return BadRequest();

        var article = _mapper.Map<Article>(articleDto);
        _articleService.Update(article);
        return NoContent();
    }


    [HttpGet("{id }")]
    public IActionResult GetById(int id)
    {
        var art = _articleService.GetById(id);

        if (art==null) return NotFound();
        var article = _mapper.Map<ArticleDto>(art);

        return Ok(article);
    }



    private static bool IsValid(ArticleDto art)
    {
        return new ArticleDtoValidator().Validate(art).IsValid;
    }
}

