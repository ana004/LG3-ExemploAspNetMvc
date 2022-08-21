using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class CalculadoraController : Controller 
{
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    public IActionResult Operacao()
    {
        return View();
    }

    public IActionResult OperacaoResultado([FromForm] double num1, [FromForm] double num2, [FromForm] string operacao) 
    {
        ViewBag.numero1 = num1;
        ViewBag.numero2 = num2;

        if(operacao == "Somar")
        {
            ViewBag.operacao = "soma";
            ViewBag.operador = "+";
            ViewBag.resultado = num1 + num2;
        }

        if(operacao == "Subtrair")
        {
            ViewBag.operacao = "subtração";
            ViewBag.operador = "-";
            ViewBag.resultado = num1 - num2;
        }

        if(operacao == "Multiplicar")
        {
            ViewBag.operacao = "multiplicação";
            ViewBag.operador = "x";
            ViewBag.resultado = num1 * num2;
        }

        if(operacao == "Dividir")
        {
            ViewBag.operacao = "divisão";
            ViewBag.operador = "+";
            ViewBag.resultado = num1 / num2;
        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}