using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.ViewModels;

namespace GrepuuTemplates.NetApp.Web.Areas.Articles.Providers;

public class ArticlesManagementProvider : IArticlesManagementProvider
{
    public ArticlesManagementProvider()
    {
        
    }
    
    public ArticlesManagementListVm PrepareListVm(bool withArchived)
    {
        return new ArticlesManagementListVm();
    }

    public ArticlesManagementDetailsVm PrepareDetailsVm(int id)
    {
        return new ArticlesManagementDetailsVm();
    }

    public ArticlesManagementAddVm PrepareAddVm(int id)
    {
        return new ArticlesManagementAddVm();
    }

    public ArticlesManagementChangeVm PrepareChangeVm(int id)
    {
        return new ArticlesManagementChangeVm();
    }

    public ArticlesManagementRemoveVm PrepareRemoveVm(int id)
    {
        return new ArticlesManagementRemoveVm();
    }
}