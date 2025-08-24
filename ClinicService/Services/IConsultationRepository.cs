using ClinicService.Models;
/// <summary>
/// Конкретный тип интерфейса репозитория для работы со справочником записи на консультацию в БД
/// </summary>
namespace ClinicService.Services
{
    public interface IConsultationRepository : IRepository<Consultation, int> { }
}
