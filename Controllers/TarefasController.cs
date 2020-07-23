using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Controllers
{
  public class TarefasController : Controller
  {
    //lista de tarefas
    public IActionResult Index()
    {
      //obter os dados e retornar
      return View();
    }
  }
}