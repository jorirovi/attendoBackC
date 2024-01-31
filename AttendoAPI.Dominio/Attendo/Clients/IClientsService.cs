using System;
using AttendoAPI.Comunes.Clasess.Contratos.Clients;

namespace AttendoAPI.Dominio.Attendo.Clients
{
	public interface IClientsService
	{
		Task<ClientsContract> GetClientsByName(string name);
		Task<ClientsContactContract> GetClientesContact(string name);
		Task<List<ClientsContactContract>> GetlistClients();
	}
}

