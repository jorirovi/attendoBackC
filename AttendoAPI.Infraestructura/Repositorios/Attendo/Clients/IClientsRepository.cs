using AttendoAPI.Infraestructura.DataBase.Entity;

namespace AttendoAPI.Infraestructura.Repositorios.Attendo.Clients
{
	public interface IClientsRepository
	{
		Task<ClientsEntity> GetByName(string name);
	}
}

