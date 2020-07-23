using System.Collections.Generic;
using System.Threading.Tasks;
using online_snack_bar.Models;


namespace online_snack_bar.Services
{
  public interface ITarefaItemService
  {
    Task<IEnumberable<TarefaItem>> GetItemAsync();
  }
}