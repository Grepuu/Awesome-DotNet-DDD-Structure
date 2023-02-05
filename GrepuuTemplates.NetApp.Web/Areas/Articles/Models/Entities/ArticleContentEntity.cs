using GrepuuTemplates.NetApp.Core;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Entities;

public class ArticleContentEntity : BaseEntity
{
    /// <summary>
    /// content of article without any html formatting, as plain text
    /// </summary>
    public string TextContent { get; set; }
    
    /// <summary>
    /// content of article with all html formatting
    /// </summary>
    public string HtmlContent { get; set; }
    
    /// <summary>
    /// Reverse reference to article object
    /// </summary>
    public ArticleEntity Article { get; set; }
}