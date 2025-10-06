// Services/NewsService.cs
namespace CollegeInfoApp.Services;

public class NewsService
{
    private readonly HttpClient _httpClient;

    public NewsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Async method to download college news from a URL
    /// </summary>
    /// <param name="url">The URL to download news from</param>
    /// <returns>News content as string</returns>
    public async Task<string> DownloadCollegeNewsAsync(string url)
    {
        try
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        catch (Exception ex)
        {
            return $"Error downloading news: {ex.Message}";
        }
    }

    /// <summary>
    /// Get sample college news (for demonstration)
    /// </summary>
    /// <returns>List of news items</returns>
    public async Task<List<string>> GetSampleNewsAsync()
    {
        await Task.Delay(500); // Simulate async operation
        
        return new List<string>
        {
            "Engineering Department wins National Innovation Award 2025",
            "New Computer Science Lab inaugurated with state-of-the-art equipment",
            "College achieves 95% placement rate for graduating batch",
            "Annual Tech Fest scheduled for next month",
            "Guest lecture by industry expert on AI and Machine Learning"
        };
    }
}