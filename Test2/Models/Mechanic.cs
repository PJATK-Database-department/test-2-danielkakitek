using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class Mechanic
{
    [Key]
    public int IdMechanic { get; set; }
    
    [MaxLength(20)]
    public string FirstName { get; set; }
    
    [MaxLength(30)]
    public string LastName { get; set; }
    
    public virtual ICollection<Inspection> Inspections { get; set; }
}