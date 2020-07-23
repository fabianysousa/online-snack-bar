using System;

namespace online_snack_bar.Models
{
  public class TarefaItem
  {
    public System.Guid Id { get; set; }
    public bool EstaCompleta { get; set; }
    public string Nome { get; set; }
    public DateTimeOffset? DataConclusao { get; set; }
  }
}