using ClinicService.Models;

namespace ClinicService.Services
{
    public interface IRepository<T, TId> // T, TId обобщенный параметр
    {
        int Create(T item);//регистрируем клиента в нашей системе
        int Update(T item);

        int Delete(TId id);

        T GetById(TId id);
        List<T> GetAll();
    }
}
