using AttendoAPI.Infraestructura.DataBase.Entity;

namespace AttendoAPI.Infraestructura.Repositorios.Attendo.General
{
	public interface IAttendoRepository<T>
	{
        Task<T> GetbyID(int id);
        Task<List<T>> GetAll();
    }
}

