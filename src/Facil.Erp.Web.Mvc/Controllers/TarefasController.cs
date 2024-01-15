using Abp.AspNetCore.Mvc.Authorization;
using Facil.Erp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Facil.Erp.Web.Controllers;

[AbpMvcAuthorize]
public class TarefasController : ErpControllerBase
{
    public IActionResult Index()
    {
        return View();
    }
}
