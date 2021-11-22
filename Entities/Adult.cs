using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities {
public class Adult : Person {
    [Required]
    public Job JobTitle { get; set; }
}
}