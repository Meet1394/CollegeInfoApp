// Models/Course.cs
namespace CollegeInfoApp.Models;

public class Course
{
    public int Id { get; set; }
    public string? CourseName { get; set; }
    public string? CourseCode { get; set; }
    public int? Credits { get; set; }
    public string? Department { get; set; }
    public int? Duration { get; set; } // in years
}