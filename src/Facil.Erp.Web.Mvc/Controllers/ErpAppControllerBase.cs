using Abp.AspNetCore.Mvc.Controllers;

namespace Facil.Erp.Web.Controllers;


public abstract class ErpAppControllerBase : AbpController
{
    protected ErpAppControllerBase()
    {
        LocalizationSourceName = ErpConsts.LocalizationSourceName;
    }
}
