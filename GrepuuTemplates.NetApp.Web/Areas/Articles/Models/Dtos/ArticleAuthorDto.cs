using GrepuuTemplates.NetApp.Core;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Dtos;

public class ArticleAuthorDto : BaseDto
{
    public string Name { get; set; }
    public string Subtitle { get; set; }
    public string SeoAuthor { get; set; }
    public int Age { get; set; }
    
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Title { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public bool IsEmailPublic { get; set; }
}