using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facil.Erp.Pessoas;

[Table("AppPessoas")]
public class Pessoa :  AuditedEntity<Guid>
{
    public const int MaxNameLength = 32;

    [Required]
    [MaxLength(MaxNameLength)]
    public string Nome { get; set; }

    public Pessoa()
    {

    }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}
