using Microsoft.AspNetCore.Mvc;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Controllers;

public class ArticlesPublicController : Controller
{
    public ArticlesPublicController()
    {
        
    }
    
    [HttpGet]
    public IActionResult List()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Details()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddComment()
    {
        return NotFound();
    }
}