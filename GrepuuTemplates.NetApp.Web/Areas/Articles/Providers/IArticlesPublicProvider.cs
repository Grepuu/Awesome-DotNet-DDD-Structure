using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.ViewModels;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;

public interface IArticlesPublicProvider
{
    ArticlesPublicListVm PrepareList(bool withArchived);
    ArticlesPublicDetailsVm PrepareDetails(Guid id);
}