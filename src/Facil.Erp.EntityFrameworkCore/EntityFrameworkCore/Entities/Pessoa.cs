using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facil.Erp.EntityFrameworkCore.Entities;

[Table("Pessoas")]
public class Pessoa : Entity<Guid>
{
   

    public Pessoa(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public string Nome { get; set; }
    public string Email { get; set; }
}
