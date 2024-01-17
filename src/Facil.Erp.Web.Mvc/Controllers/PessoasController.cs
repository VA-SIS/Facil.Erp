using Abp.AspNetCore.Mvc.Authorization;
using Facil.Erp.Controllers;
using Facil.Erp.Pessoas;
using Microsoft.AspNetCore.Mvc;

namespace Facil.Erp.Web.Controllers;

[AbpMvcAuthorize]
public class PessoasController : ErpControllerBase
{
    private readonly IPessoaAppService _AppService;

    public PessoasController(IPessoaAppService appService)
    {
        _AppService = appService;
    }

    public IActionResult Index()
    {
        return View();
    }
}
