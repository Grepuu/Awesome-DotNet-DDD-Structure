using Microsoft.AspNetCore.Mvc;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Controllers;

public class ArticlesManagementController : Controller
{
    public ArticlesManagementController()
    {
        
    }
    
    [HttpGet]
    public IActionResult List(bool showArchived)
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Details()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(object obj)
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Change()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Change(object obj)
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Remove()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Remove(object obj)
    {
        return View();
    }
}