using Microsoft.AspNetCore.Mvc;
using online_snack_bar.Services;

namespace online_snack_bar.Controllers
{
  public class TarefasController : Controller
  {
    ITarefaItemService _tarefaService;
    public TarefasController(ITarefaItemService tarefaService)
    {
      _tarefaService = tarefaService;
    }
    //lista de tarefas
    public IActionResult Index()
    {
      var tarefas = _tarefaService.GetItemAsync();
      return View();
    }
  }
}