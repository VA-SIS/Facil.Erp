using Abp.Application.Services;
using Facil.Erp.Pessoas.Dtos;

namespace Facil.Erp.Pessoas;

public interface IPessoaAppService : IAsyncCrudAppService<PessoaDto, int, PagedPessoaResultRequestDto, CreatePessoaDto, PessoaDto>
{

}
