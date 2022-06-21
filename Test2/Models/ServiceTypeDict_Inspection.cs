using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

public class ServiceTypeDict_Inspection
{
    [Key]
    public int IdServiceType { get; set; }

    [ForeignKey("IdServiceType")]
    public ServiceTypeDict ServiceTypeDict { get; set; }

    
    public int IdInspection { get; set; }

    [ForeignKey("IdInspection")]
    public Inspection Inspection { get; set; }

    [MaxLength(300)]
    public String Comments { get; set; }
    
}