using Abp.Application.Services.Dto;
using Facil.Erp.Common;
using Facil.Erp.Tasks;
using Facil.Erp.Tasks.Dtos;
using Facil.Erp.Web.Models.People;
using Facil.Erp.Web.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Facil.Erp.Web.Controllers;

public class TasksController : ErpAppControllerBase
{
    private readonly ITaskAppService _taskAppService;
    private readonly ILookupAppService _lookupAppService;

    public TasksController(
        ITaskAppService taskAppService,
        ILookupAppService lookupAppService)
    {
        _taskAppService = taskAppService;
        _lookupAppService = lookupAppService;
    }

    public async Task<ActionResult> Index(GetAllTasksInput input)
    {
        var output = await _taskAppService.GetAll(input);

        var model = new IndexViewModel(output.Items)
        {
            SelectedTaskState = input.State
        };

        return View(model);
    }

    public async Task<ActionResult> Create()
    {
        var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems()).Items
            .Select(p => p.ToSelectListItem())
            .ToList();

        peopleSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("Unassigned"), Selected = true });

        return View(new CreateTaskViewModel(peopleSelectListItems));
    }
}

