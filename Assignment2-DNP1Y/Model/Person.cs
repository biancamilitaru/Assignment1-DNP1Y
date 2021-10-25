using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Age")]
    public int Age { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Weight")]
    public float Weight { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0 for Height")]
    public int Height { get; set; }
    public string Sex { get; set; }
}


}