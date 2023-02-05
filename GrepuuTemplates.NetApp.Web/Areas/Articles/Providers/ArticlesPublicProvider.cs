using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.ViewModels;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;

public class ArticlesPublicProvider : IArticlesPublicProvider
{
    public ArticlesPublicProvider()
    {
        
    }
    
    public ArticlesPublicListVm PrepareList(bool withArchived)
    {
        return new ArticlesPublicListVm();
    }

    public ArticlesPublicDetailsVm PrepareDetails(Guid id)
    {
        return new ArticlesPublicDetailsVm();
    }
}