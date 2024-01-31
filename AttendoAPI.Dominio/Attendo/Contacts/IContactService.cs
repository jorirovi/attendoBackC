using AttendoAPI.Comunes.Clasess.Contratos.Contacts;

namespace AttendoAPI.Dominio.Attendo.Contacts
{
	public interface IContactService
	{
		Task<ContactContract> GetByName(string name);
	}
}

