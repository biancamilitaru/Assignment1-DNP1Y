using System.ComponentModel.DataAnnotations;

namespace Entities {
public abstract class Person {
    
    [Key, MaxLength(7)]
    public int Id { get; set; }
    [Required, MaxLength(20)]
    public string FirstName { get; set; }
    [Required, MaxLength(20)]
    public string LastName { get; set; }
    [Required, MaxLength(20)]
    public string HairColor { get; set; }
    [Required, MaxLength(20)]
    public string EyeColor { get; set; }
    [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Age")]
    public int Age { get; set; }
    [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Weight")]
    public float Weight { get; set; }
    [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Height")]
    public int Height { get; set; }
    [Required, MaxLength(20)]
    public string Sex { get; set; }
}


}