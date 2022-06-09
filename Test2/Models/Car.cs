using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class Car
{
    [Key]
    public int IdCar { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }
    
    public int ProductionYear { get; set; }
    
    public virtual ICollection<Inspection> Inspections { get; set; }
}