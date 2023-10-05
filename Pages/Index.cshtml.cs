using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1_SahilRai.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int yearInput { get; set; }
    public string ZodiacSign { get; set; }
    public int CurrentYear { get; set; }
    public string imageSrc { get; set; }

    public void OnGet(){
        CurrentYear = DateTime.Now.Year;
    }

    public void OnPost(){
        if (yearInput < 1900 || yearInput > 2024){
            ZodiacSign = "Choose year only between 1900 and 2024";
            imageSrc = "";
        } else {
            Utils util = new Utils();
            ZodiacSign = Utils.GetZodiac(yearInput % 12).ToLower();
            imageSrc = "/images/rabbit.png";
        }
    }
}
