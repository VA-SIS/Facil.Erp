using Abp.Application.Services;
using Facil.Erp.Entidades.Pessoas;
using System.Collections.Generic;

namespace Facil.Erp.Pessoas;

public interface IPessoaAppService : IApplicationService
{
    Pessoa AddPessoa(Pessoa pessoa);
    List<Pessoa> GetAll();
}
