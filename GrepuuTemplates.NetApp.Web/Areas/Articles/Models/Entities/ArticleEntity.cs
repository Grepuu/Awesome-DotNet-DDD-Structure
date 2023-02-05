using GrepuuTemplates.NetApp.Core;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Entities;

public class ArticleEntity : BaseEntity
{
    /// <summary>
    /// title of article
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// property for list of seo keywords
    /// </summary>
    public string Keywords { get; set; }
    
    /// <summary>
    /// property for seo description
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// short description for thumbnail purposes 
    /// </summary>
    public string ShortSummary { get; set; }
    
    /// <summary>
    /// virtual property for article's author
    /// </summary>
    public ArticleAuthorEntity Author { get; set; }
    
    /// <summary>
    /// reference to author's object
    /// </summary>
    public Guid AuthorForeignKey { get; set; }

    /// <summary>
    /// virtual property for article's content
    /// </summary>
    public ArticleContentEntity Content { get; set; }
    
    /// <summary>
    /// reference to content's object
    /// </summary>
    public Guid ContentForeignKey { get; set; }
}