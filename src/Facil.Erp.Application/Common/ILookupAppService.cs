using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System.Threading.Tasks;

namespace Facil.Erp.Common;
public interface ILookupAppService : IApplicationService
{
    Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems();
}