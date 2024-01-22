using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Facil.Erp.Authorization;
using Facil.Erp.Controllers;
using Facil.Erp.Pessoas;
using Facil.Erp.Web.Models.Pessoas;
using Facil.Erp.Web.Models.Roles;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Facil.Erp.Web.Controllers;

[AbpMvcAuthorize]
//[AbpMvcAuthorize(PermissionNames.Pages_Pessoas)]
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


    //public async Task<ActionResult> EditModal(Guid id)
    //{
    //    var output = await _AppService.GetPessoaForEdit(new EntityDto<Guid>(id));
    //    var model = ObjectMapper.Map<EditPessoaModalViewModel>(output);

    //    return PartialView("_EditModal", model);
    //}
}
