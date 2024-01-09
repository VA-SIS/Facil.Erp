using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Facil.Erp.People;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Facil.Erp.Common;

public class LookupAppService : ErpAppServiceBase, ILookupAppService
{
    private readonly IRepository<Person, Guid> _personRepository;

    public LookupAppService(IRepository<Person, Guid> personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems()
    {
        var people = await _personRepository.GetAllListAsync();
        return new ListResultDto<ComboboxItemDto>(
            people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
        );
    }
}
