using GrepuuTemplates.NetApp.Core;
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

public class ArticlesManagementProvider : BaseProvider, IArticlesManagementProvider
{
    public ArticlesManagementProvider()
    {
        
    }
    
    public ArticlesManagementListVm PrepareListVm(bool withArchived)
    {
        return new ArticlesManagementListVm();
    }

    public ArticlesManagementDetailsVm PrepareDetailsVm(Guid id)
    {
        return new ArticlesManagementDetailsVm();
    }

    public ArticlesManagementAddVm PrepareAddVm(Guid id)
    {
        return new ArticlesManagementAddVm();
    }

    public ArticlesManagementChangeVm PrepareChangeVm(Guid id)
    {
        return new ArticlesManagementChangeVm();
    }

    public ArticlesManagementRemoveVm PrepareRemoveVm(Guid id)
    {
        return new ArticlesManagementRemoveVm();
    }
}