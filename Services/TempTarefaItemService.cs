using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using online_snack_bar.Models;

namespace online_snack_bar.Services
{
  public class TempTarefaItemService : ITarefaItemService
  {
    public Task<IEnumerable<TarefaItem>> GetItemAsync()
    {
      // Retorna um array de itens de tarefa
      IEnumerable<TarefaItem> items = new[]
      {
          new TarefaItem
          {
              Nome = "Aprender ASP.NET Core",
              EstaCompleta = false,
              DataConclusao = DateTimeOffset.Now.AddDays(30)
          },
          new TarefaItem
          {
              Nome = "Criar aplicações Web",
              EstaCompleta = false,
              DataConclusao = DateTimeOffset.Now.AddDays(60)
          }
      };
      return Task.FromResult(items);
    }

    Task<IEnumberable<TarefaItem>> ITarefaItemService.GetItemAsync()
    {
      throw new NotImplementedException();
    }
  }
}