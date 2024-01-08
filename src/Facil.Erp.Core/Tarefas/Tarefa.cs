using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil.Erp.Tarefas;

[Table("AppTarefas")]
public class Tarefa : Entity, IHasCreationTime
{
    public const int MaxTitleLength = 256;
    public const int MaxDescriptionLength = 64 * 1024; //64KB

    [Required]
    [MaxLength(MaxTitleLength)]
    public string Titulo { get; set; }

    [MaxLength(MaxDescriptionLength)]
    public string Descricao { get; set; }


    public DateTime CreationTime { get; set; }

    //public TaskState State { get; set; }

}
