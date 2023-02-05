using GrepuuTemplates.NetApp.Core;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Entities;

public class ArticleAuthorEntity : BaseEntity
{
    /// <summary>
    /// property for storing first name of author
    /// </summary>
    public string Firstname { get; set; }
    
    /// <summary>
    /// property for storing surname of author
    /// </summary>
    public string Lastname { get; set; }
    
    /// <summary>
    /// job title or subtitle for better recognizing author
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// birthday of author
    /// </summary>
    public DateTime BirthDate { get; set; }
    
    /// <summary>
    /// email address used by author for contact and seo
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// validates if email can be publicly shown
    /// </summary>
    public bool IsEmailPublic { get; set; }

    /// <summary>
    /// validates if lastname can be publicly shown
    /// </summary>
    public bool IsLastnamePublic { get; set; }
    
    /// <summary>
    /// Reverse reference to article object
    /// </summary>
    public ArticleEntity Article { get; set; }
}