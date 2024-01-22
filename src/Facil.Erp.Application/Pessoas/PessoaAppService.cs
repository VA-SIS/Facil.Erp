using Abp.Application.Services.Dto;
using Facil.Erp.Entidades.Pessoas;
using Facil.Erp.Pessoas.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facil.Erp.Pessoas;

/// <summary>
/// 
/// </summary>
public class PessoaAppService : ErpAppServiceBase, IPessoaAppService
{
    public Pessoa AddPessoa(Pessoa pessoa)
    {
        throw new System.NotImplementedException();
    }

    public List<Pessoa> GetAll()
    {
        throw new System.NotImplementedException();
    }

    public Task<GetPessoaForEditOutput> GetPessoaForEdit(EntityDto input)
    {
        throw new System.NotImplementedException();
    }

    public Task<ListResultDto<PessoasListDto>> GetPessoasAsync()
    {
        throw new System.NotImplementedException();
    }
}
