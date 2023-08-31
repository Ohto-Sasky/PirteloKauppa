using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class Maksaminen : PageModel
{
    private readonly ILogger<Maksaminen> _logger;

    public Maksaminen(ILogger<Maksaminen> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

