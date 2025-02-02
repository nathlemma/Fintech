using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class StockController: ControllerBase //base class designed to handle http request and response 
{
    private readonly ApplicationDbContext _context;
    
    public StockController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var stocks = _context.Stocks.ToList();  //deferred execution
        return Ok(stocks);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id) //Model binding, .net extracts the id as string and turns it into id
    {
        var stock = _context.Stocks.Find(id);
        if (stock == null) return NotFound();
        return Ok(stock);
    }
}