using Abp.Application.Services.Dto;

namespace Facil.Erp.Pessoas.Dtos;

/// <summary>
/// 
/// </summary>
public class PagedPessoaResultRequestDto : PagedResultRequestDto
{
    public string Keyword { get; set; }
    public bool? IsActive { get; set; }
}
