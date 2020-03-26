using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace todo_server.Models
{
  public class Todo
  {
    [Key]
    public int Id { get; set; }

    [Column(TypeName ="varchar(100)")]
    public string Description { get; set; }

    [Column(TypeName ="varchar(30)")]
    public string State { get; set; }
  }
}