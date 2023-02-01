﻿namespace KrasovPizzaModel;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public string? Photo { get; set; }
    public double Weigth { get; set; }
}