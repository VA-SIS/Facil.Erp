using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Facil.Erp.Entidades.Pessoas;
using Facil.Erp.Pessoas.Dtos;
using Facil.Erp.Roles.Dto;
using Facil.Erp.Tasks.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facil.Erp.Pessoas;

/// <summary>
/// 
/// </summary>
public interface IPessoaAppService : IApplicationService
{
    //Task<ListResultDto<PessoasListDto>> GetAll();


    Pessoa AddPessoa(Pessoa pessoa);

    Task<GetPessoaForEditOutput> GetPessoaForEdit(EntityDto input);

    Task<ListResultDto<PessoasListDto>> GetPessoasAsync();
}



