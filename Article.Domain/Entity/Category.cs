﻿namespace Article.Domain.Entity;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public bool IsActive { get; set; }
}