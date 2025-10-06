// Models/Teacher.cs
namespace CollegeInfoApp.Models;

public class Teacher
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Department { get; set; }
    public string? Specialization { get; set; }
    public int? YearsOfExperience { get; set; }
}