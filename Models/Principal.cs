// Models/Principal.cs
namespace CollegeInfoApp.Models;

public class Principal
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public DateTime? AppointmentDate { get; set; }
    public string? Qualifications { get; set; }
}