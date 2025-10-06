// Controllers/HomeController.cs
namespace CollegeInfoApp.Controllers;

public class HomeController : Controller
{
    private readonly NewsService _newsService;

    public HomeController(NewsService newsService)
    {
        _newsService = newsService;
    }

    // Index method returning MyView
    public async Task<IActionResult> Index()
    {
        // Get greeting message based on system time
        var currentHour = DateTime.Now.Hour;
        string greeting;
        string imageName;

        if (currentHour >= 5 && currentHour < 12)
        {
            greeting = "Good Morning";
            imageName = "sunrise.jpg";
        }
        else if (currentHour >= 12 && currentHour < 17)
        {
            greeting = "Good Afternoon";
            imageName = "midday.jpg";
        }
        else
        {
            greeting = "Good Evening";
            imageName = "sunset.jpg";
        }

        ViewBag.Greeting = greeting;
        ViewBag.ImageName = imageName;
        ViewBag.CurrentTime = DateTime.Now.ToString("hh:mm tt");

        // Get college news
        var news = await _newsService.GetSampleNewsAsync();
        ViewBag.News = news;

        // Demonstrate extension method
        var sampleStudent = new Student
        {
            Id = 1,
            FirstName = "Raj",
            LastName = "Patel",
            Email = "raj.patel@college.edu",
            Department = "Computer Engineering",
            RollNumber = 2021001
        };
        ViewBag.StudentFullName = sampleStudent.GetFullName();

        return View("MyView");
    }

    public IActionResult Welcome()
    {
        return View();
    }

    // Cookies Demo
    public IActionResult CookiesDemo()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveCookie(string studentName, string studentEmail)
    {
        CookieOptions options = new CookieOptions
        {
            Expires = DateTime.Now.AddDays(7),
            HttpOnly = true
        };

        Response.Cookies.Append("StudentName", studentName ?? "", options);
        Response.Cookies.Append("StudentEmail", studentEmail ?? "", options);

        ViewBag.Message = "Cookie saved successfully!";
        ViewBag.StudentName = studentName;
        ViewBag.StudentEmail = studentEmail;

        return View("CookiesDemo");
    }

    public IActionResult ReadCookie()
    {
        var studentName = Request.Cookies["StudentName"];
        var studentEmail = Request.Cookies["StudentEmail"];

        ViewBag.StudentName = studentName ?? "No cookie found";
        ViewBag.StudentEmail = studentEmail ?? "No cookie found";
        ViewBag.Message = "Cookie retrieved successfully!";

        return View("CookiesDemo");
    }

    public IActionResult DeleteCookie()
    {
        Response.Cookies.Delete("StudentName");
        Response.Cookies.Delete("StudentEmail");

        ViewBag.Message = "Cookies deleted successfully!";
        return View("CookiesDemo");
    }

    // Session Demo
    public IActionResult SessionDemo()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveSession(string studentName, string studentDepartment, int rollNumber)
    {
        HttpContext.Session.SetString("StudentName", studentName ?? "");
        HttpContext.Session.SetString("StudentDepartment", studentDepartment ?? "");
        HttpContext.Session.SetInt32("RollNumber", rollNumber);

        ViewBag.Message = "Session saved successfully!";
        ViewBag.StudentName = studentName;
        ViewBag.StudentDepartment = studentDepartment;
        ViewBag.RollNumber = rollNumber;

        return View("SessionDemo");
    }

    public IActionResult ReadSession()
    {
        var studentName = HttpContext.Session.GetString("StudentName");
        var studentDepartment = HttpContext.Session.GetString("StudentDepartment");
        var rollNumber = HttpContext.Session.GetInt32("RollNumber");

        ViewBag.StudentName = studentName ?? "No session found";
        ViewBag.StudentDepartment = studentDepartment ?? "No session found";
        ViewBag.RollNumber = rollNumber?.ToString() ?? "No session found";
        ViewBag.Message = "Session retrieved successfully!";

        return View("SessionDemo");
    }

    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        ViewBag.Message = "Session cleared successfully!";
        return View("SessionDemo");
    }

    // Query String Demo
    public IActionResult QueryStringDemo(string? name, string? department, int? rollNumber)
    {
        ViewBag.StudentName = name ?? "Not provided";
        ViewBag.StudentDepartment = department ?? "Not provided";
        ViewBag.RollNumber = rollNumber?.ToString() ?? "Not provided";

        return View();
    }

    // Hidden Field Demo
    public IActionResult HiddenFieldDemo()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ProcessHiddenField(int studentId, string studentName, string hiddenData)
    {
        ViewBag.StudentId = studentId;
        ViewBag.StudentName = studentName;
        ViewBag.HiddenData = hiddenData;
        ViewBag.Message = "Hidden field data processed successfully!";

        return View("HiddenFieldDemo");
    }
}