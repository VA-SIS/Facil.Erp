using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System.Threading.Tasks;
using Facil.Erp.Tasks.Dtos;

namespace Facil.Erp.Tasks;

public interface ITaskAppService : IApplicationService
{
    Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);

    System.Threading.Tasks.Task Create(CreateTaskInput input);
}