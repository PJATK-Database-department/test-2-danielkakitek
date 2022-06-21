using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class ServiceTypeDict
{
    [Key]
    public int IdServiceType { get; set; }
    
    [MaxLength(20)]
    public string ServiceType { get; set; }
    
    public float Price { get; set; }
    
    public virtual ICollection<ServiceTypeDict_Inspection> ServiceTypeDict_Inspections { get; set; }
}