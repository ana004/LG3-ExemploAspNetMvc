using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class OperationCreateDto 
{
    
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
}

public class OperacoesMatematicasController : Controller
{
    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Soma()
    {
        return View();
    }

    public IActionResult SomaResultado([FromForm] double num1, [FromForm] double num2) 
    {
        ViewBag.numero1 = num1;
        ViewBag.numero2 = num2;

        ViewBag.resultado = num1 + num2;
        
        return View();
    }

    public IActionResult Subtracao()
    {
        return View();
    }

    public IActionResult SubtracaoResultado([FromForm] double num1, [FromForm] double num2) 
    {
        ViewBag.numero1 = num1;
        ViewBag.numero2 = num2;

        ViewBag.resultado = num1 - num2;
        
        return View();
    }

    public IActionResult Multiplicacao()
    {
        return View();
    }

    public IActionResult MultiplicacaoResultado([FromForm] double num1, [FromForm] double num2) 
    {
        ViewBag.numero1 = num1;
        ViewBag.numero2 = num2;

        ViewBag.resultado = num1 * num2;
        
        return View();
    }

    public IActionResult Divisao()
    {
        return View();
    }

    public IActionResult DivisaoResultado([FromForm] double num1, [FromForm] double num2) 
    {
        ViewBag.numero1 = num1;
        ViewBag.numero2 = num2;

        ViewBag.resultado = num1 / num2;
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
