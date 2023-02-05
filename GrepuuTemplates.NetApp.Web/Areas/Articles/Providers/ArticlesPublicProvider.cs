using GrepuuTemplates.NetApp.Core;
using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.ViewModels;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;

public interface IArticlesPublicProvider
{
    ArticlesPublicListVm PrepareList(bool withArchived);
    ArticlesPublicDetailsVm PrepareDetails(Guid id);
}

public class ArticlesPublicProvider : BaseProvider, IArticlesPublicProvider
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