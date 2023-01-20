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
        Cliente cliente01 = new Cliente(01, "Arthur", "123.456.789", "Gabrielvherculano@gmail.com", "Madruga");
        Cliente cliente02 = new Cliente(02, "Gabriel", "223.446.769", "Gabrielvherculano@gmail.com", "Apollo");
        Cliente cliente03 = new Cliente(03, "Adassa", "773.777.789", "Adassam@gmail.com", "Alemão");
        Cliente cliente04 = new Cliente(04, "Celma", "444.456.749", "celmaM@gmail.com", "Mel");
        Cliente cliente05 = new Cliente(05, "Iara", "555.555.555", "IaraVN@gmail.com", "Poppy");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente01);
        listaClientes.Add(cliente02);
        listaClientes.Add(cliente03);
        listaClientes.Add(cliente04);
        listaClientes.Add(cliente05);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl alt dog", "14.182.102/0001-80", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "bootsret INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "11.111.106/0001-03", "contato@bff.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
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
