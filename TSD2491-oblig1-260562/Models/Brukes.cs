using System.ComponentModel.DataAnnotations;

namespace TSD2491_oblig1_260562;

public class Bruker
{
    public string? Navn { get; set; }
    [DataType(DataType.Date)]
    public string? KontaktInformasjon { get; set; }
    public int AntallSpillrunder { get; set; }
}