using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyApp.Models;

public class Emp
{
    [Key]
    [Column("EmpId")]
    public string Id { get; set; }

    public string EmpName { get; set; }

    public string Age { get; set; }

    public string Sal { get; set; } 


}
