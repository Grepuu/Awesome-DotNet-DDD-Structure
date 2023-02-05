using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.ViewModels;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;

public interface IArticlesManagementProvider
{
    ArticlesManagementListVm PrepareListVm(bool withArchived);
    ArticlesManagementDetailsVm PrepareDetailsVm(Guid id);
    ArticlesManagementAddVm PrepareAddVm(Guid id);
    ArticlesManagementChangeVm PrepareChangeVm(Guid id);
    ArticlesManagementRemoveVm PrepareRemoveVm(Guid id);
}