using ClinicService.Models;
using System.Security.Cryptography;
/// <summary>
/// Обобщенный интерфейс репозиторий для работы с БД по записям
/// </summary>
/// <typeparam name="T">Класс записи (клиент, животное, запись на консультацию)</typeparam>
/// <typeparam name="TId">Идентификатор записи (клиент, животное, запись на консультацию)</typeparam>
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

/// <summary>
/// Создание записи (клиент, животное, запись на консультацию)
/// </summary>
/// <param name="item">Переданные данные для записи</param>
/// <returns>Результат создания записи в БД</returns>


/// <summary>
/// Редактирование записи (клиент, животное, запись на консультацию)
/// </summary>
/// <param name="item">Переданные данные для изменения записи</param>
/// <returns>Результат изменение записи в БД</returns>


/// <summary>
/// Удаление записи по ID
/// </summary>
/// <param name="id">Идентификатор записи в БД (клиент, животное, запись на консультацию)</param>
/// <returns>Результат удаления записи из БД</returns>


/// <summary>
/// Получение записи из БД по ID (клиент, животное, запись на консультацию)
/// </summary>
/// <param name="id">Идентификатор записи в БД (клиент, животное, запись на консультацию)</param>
/// <returns>Информацию из БД по запрошенной записи</returns>


/// <summary>
/// Получение всех записей в программе
/// </summary>
/// <returns>Всех записей по справочнику класса записи</returns>