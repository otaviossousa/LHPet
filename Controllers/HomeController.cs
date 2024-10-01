using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        // Instanciando clientes
        Cliente cliente1 = new Cliente(1, "João", "123.456.789-00", "joao@exemplo.com", "Rex");
        Cliente cliente2 = new Cliente(2, "Maria", "987.654.321-00", "maria@exemplo.com", "Totó");
        Cliente cliente3 = new Cliente(3, "José", "111.222.333-44", "jose@exemplo.com", "Bolinha");
        Cliente cliente4 = new Cliente(4, "Ana", "555.666.777-88", "ana@exemplo.com", "Luna");
        Cliente cliente5 = new Cliente(5, "Carlos", "999.888.777-66", "carlos@exemplo.com", "Branco");

        // Criando uma lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        
        // Adicionando clientes à lista de clientes
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Instanciando fornecedores
        Fornecedor fornecedor1 = new Fornecedor(1, "Petcom", "12.346.789/0001-00", "petcom@exemplo.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "PetLove", "98.765.432/0001-00", "petlove@exemplo.com");
        Fornecedor fornecedor3 = new Fornecedor(3, "PetShop", "11.222.333/0001-44", "petshop@exemplo.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "PetFeliz", "55.666.777/0001-88", "petfeliz@exemplo.com");
        Fornecedor fornecedor5 = new Fornecedor(5, "PetAmigo", "99.888.777/0001-66", "petamigo@exemplo.com");

        // Criando uma lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        
        // Adicionando fornecedores à lista de fornecedores
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
