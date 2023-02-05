using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Dtos;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Controllers;

[Area("Articles")]
public class ArticlesManagementController : Controller
{
    private readonly ArticlesManagementProvider _vmProvider;
    private readonly IArticlesManagementService _service;
    
    public ArticlesManagementController(
        ArticlesManagementProvider vmProvider,
        IArticlesManagementService service)
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
        return View(_vmProvider.PrepareListVm(showArchived));
    }
    
    /// <summary>
    /// Method for showing one article chosen from the list
    /// </summary>
    /// <param name="id">unique number of article</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Details(Guid id)
    {
        return View(_vmProvider.PrepareDetailsVm(id));
    }
    
    /// <summary>
    /// Method for showing form for creating new article
    /// </summary>
    /// <param name="id">unique number of article</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    
    /// <summary>
    /// Method for receiving post request from form of adding new article
    /// </summary>
    /// <param name="model">filled article object</param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Add(ArticleDto model)
    {
        return View();
    }
    
    /// <summary>
    /// Method for showing one article as form for changing its properties
    /// </summary>
    /// <param name="id">unique number of article</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Change(Guid id)
    {
        return View(_vmProvider.PrepareDetailsVm(id));
    }
    
    /// <summary>
    /// Method for receiving post request from form for changing its properties
    /// </summary>
    /// <param name="model">filled article object</param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Change(ArticleDto model)
    {
        return View();
    }
    
    /// <summary>
    /// Method for showing confirmation of article removal
    /// </summary>
    /// <param name="id">unique number of article</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Remove(Guid id)
    {
        return View(_vmProvider.PrepareDetailsVm(id));
    }
    
    /// <summary>
    /// Method for receiving post request from form of article removal
    /// </summary>
    /// <param name="model">filled article object</param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Remove(ArticleDto model)
    {
        return View();
    }
}