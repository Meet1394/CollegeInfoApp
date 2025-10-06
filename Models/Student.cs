// Models/Student.cs
namespace CollegeInfoApp.Models;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Department { get; set; }
    public int? RollNumber { get; set; }
    public DateTime? EnrollmentDate { get; set; }
}