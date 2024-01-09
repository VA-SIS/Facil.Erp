using Facil.Erp.Tasks;

namespace Facil.Erp.Tasks.Dtos;

public class GetAllTasksInput
{
    public TaskState? State { get; set; }
}