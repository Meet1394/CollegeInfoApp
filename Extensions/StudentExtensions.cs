// Extensions/StudentExtensions.cs
namespace CollegeInfoApp.Extensions;

public static class StudentExtensions
{
    /// <summary>
    /// Extension method to get the full name of a student
    /// </summary>
    /// <param name="student">The student object</param>
    /// <returns>Full name as "FirstName LastName"</returns>
    public static string GetFullName(this Student student)
    {
        if (student == null)
            return string.Empty;
        
        var firstName = student.FirstName ?? string.Empty;
        var lastName = student.LastName ?? string.Empty;
        
        return $"{firstName} {lastName}".Trim();
    }
}