using Microsoft.AspNetCore.Mvc;

namespace online_snack_bar.Controllers
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