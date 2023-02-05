using GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Controllers;

[Area("Articles")]
public class ArticlesPublicController : Controller
{
    private readonly IArticlesPublicProvider _vmProvider;
    private readonly IArticlesPublicService _service;
    
    public ArticlesPublicController(
        IArticlesPublicProvider vmProvider, 
        IArticlesPublicService service)
    {
        _vmProvider = vmProvider;
        _service = service;
    }
    
    /// <summary>
    /// Method for showing list of available articles
    /// </summary>
    /// <param name="showArchived">defines if archived(status == deleted) should be shown</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult List(bool showArchived)
    {
        return View(_vmProvider.PrepareList(showArchived));
    }
    
    /// <summary>
    /// Method for showing one article chosen from the list
    /// </summary>
    /// <param name="id">unique number of article</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Details(Guid id)
    {
        return View(_vmProvider.PrepareDetails(id));
    }
    
    /// <summary>
    /// Method for adding comment to existing article
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Details()
    {
        return NotFound();
    }
}