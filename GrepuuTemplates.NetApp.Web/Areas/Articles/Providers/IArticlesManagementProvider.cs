using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.ViewModels;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;

public interface IArticlesManagementProvider
{
    ArticlesManagementListVm PrepareListVm(bool withArchived);
    ArticlesManagementDetailsVm PrepareDetailsVm(int id);
    ArticlesManagementAddVm PrepareAddVm(int id);
    ArticlesManagementChangeVm PrepareChangeVm(int id);
    ArticlesManagementRemoveVm PrepareRemoveVm(int id);
}