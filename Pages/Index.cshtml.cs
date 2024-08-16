using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet.Pages;

public class IndexModel : PageModel
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _configuration = configuration;
        _logger = logger;
    }

    public void OnGet()
    {
        var who = _configuration["Position:name"];
        if (who is not null) Console.WriteLine(who);
    }
}
