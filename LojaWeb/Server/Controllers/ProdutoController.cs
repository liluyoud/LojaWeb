namespace LojaWeb.Server.Controllers;

using Microsoft.AspNetCore.Mvc;
using LojaWeb.Shared;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase 
{
    private readonly ILogger<WeatherForecastController> _logger;
    private Contexto _db;

    public ProdutoController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        _db = new Contexto();
        _db.Restaurar();
    }

    [HttpGet]
    public IEnumerable<Produto> GetProdutos() 
    {
        return _db.Produtos;
    }

    [HttpPost]
    public Produto PostProduto([FromBody] Produto produto)
    {
        _db.Produtos.Add(produto);
        _db.Salvar();
        return produto;
    }
}