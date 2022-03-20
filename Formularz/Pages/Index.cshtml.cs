using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Formularz.Models;

namespace Formularz.Pages
{ 
public class IndexModel : PageModel
 {
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public FizzBuzz FizzBuzz { get; set; }
    [BindProperty(SupportsGet = true)]
    public string Name { get; set; }
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        FizzBuzz = new();
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = ("user");
        }

    }

  }
}

