using AttendoAPI.Comunes.Clasess.Contratos.Clients;

namespace AttendoAPI.Dominio.Attendo.General
{
	public interface IAttendoService<T>
	{
		Task<T> GetById(int id);
		Task<List<T>> GetAll();
	}
}

