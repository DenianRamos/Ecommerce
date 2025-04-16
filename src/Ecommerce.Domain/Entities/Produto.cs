// src/Ecommerce.API/Models/Produto.cs
namespace Ecommerce.API.Models;

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
}