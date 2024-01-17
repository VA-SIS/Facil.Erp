using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using System;
using System.ComponentModel.DataAnnotations;

namespace Facil.Erp.Pessoas.Dtos;

/// <summary>
/// 
/// </summary>
public class PessoaEditDto : EntityDto<Guid>
{
    [Required]
    [StringLength(150)]
    public string Nome { get; set; }
}
