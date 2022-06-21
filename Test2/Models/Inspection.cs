using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

public class Inspection
{
    [Key]
    public int IdInspection { get; set; }
    
    public int IdCar { get; set; }
    
    [ForeignKey("IdCar")]
    public Car Car { get; set; }
    
    public int IdMechanic { get; set; }
    
    [ForeignKey("IdMechanic")]
    public Mechanic Mechanic { get; set; }
    
    public DateTime InspectionDate { get; set; }
    
    [MaxLength(300)]
    public string Comment { get; set; }
    
    public virtual ICollection<ServiceTypeDict_Inspection> ServiceTypeDict_Inspections { get; set; }
}