using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Facil.Erp.Entidades.Pessoas;
using Facil.Erp.Pessoas.Dtos;
using Facil.Erp.Tasks.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facil.Erp.Pessoas;

/// <summary>
/// 
/// </summary>
public class PessoaAppService : ErpAppServiceBase, IPessoaAppService
{
    //private readonly IRepository<Pessoa> _pessoaRepository;

    //public PessoaAppService(IRepository<Pessoa> pessoaRepository)
    //{
    //    _pessoaRepository = pessoaRepository;
    //}

    public Pessoa AddPessoa(Pessoa pessoa)
    {
        throw new System.NotImplementedException();
    }

    //public List<Pessoa> GetAll()
    //{
    //    var pessoas = _pessoaRepository.GetAll().ToList();

    //    return pessoas;
    //}

    //public async Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input)
    //{
    //    var tasks = await _taskRepository
    //        .GetAll()
    //        .Include(t => t.AssignedPerson)
    //        .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
    //        .OrderByDescending(t => t.CreationTime)
    //        .ToListAsync();

    //    return new ListResultDto<TaskListDto>(
    //        ObjectMapper.Map<List<TaskListDto>>(tasks)
    //    );
    //}

    public Task<GetPessoaForEditOutput> GetPessoaForEdit(EntityDto input)
    {
        throw new System.NotImplementedException();
    }

    public Task<ListResultDto<PessoasListDto>> GetPessoasAsync()
    {
        throw new System.NotImplementedException();
    }

    //Task<ListResultDto<PessoasListDto>> IPessoaAppService.GetAll()
    //{
    //    throw new System.NotImplementedException();
    //}
}
