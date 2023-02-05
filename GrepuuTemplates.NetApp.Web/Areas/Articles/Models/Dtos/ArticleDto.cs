using GrepuuTemplates.NetApp.Core;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Dtos;

public class ArticleDto : BaseDto
{
    public string Title { get; set; }
    public string Keywords { get; set; }
    public string Description { get; set; }
    public string ShortSummary { get; set; }
    
    public string Content { get; set; }
    public bool IsHtml { get; set; }

    public ArticleAuthorDto Author { get; set; }
}