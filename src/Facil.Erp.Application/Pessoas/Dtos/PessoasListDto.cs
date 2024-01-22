using Abp.Application.Services.Dto;
using System;

namespace Facil.Erp.Pessoas.Dtos;

public class PessoasListDto : EntityDto<Guid> //, IHasCreationTime
{
    public string Nome { get; set; }
    public string Email { get; set; }

    //public DateTime CreationTime { get; set; }
}
