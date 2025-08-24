using ClinicService.Models;
/// <summary>
/// Конкретный тип интерфейса репозитория для работы со справочником животных в БД
/// </summary>
namespace ClinicService.Services
{
    public interface IPetRepository : IRepository<Pet, int> { 
    
    }
}
