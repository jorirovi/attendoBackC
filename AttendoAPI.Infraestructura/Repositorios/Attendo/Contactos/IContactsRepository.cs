using AttendoAPI.Infraestructura.DataBase.Entity;

namespace AttendoAPI.Infraestructura.Repositorios.Attendo.Contactos
{
	public interface IContactsRepository
	{
		Task<ContactEntity> GetByName(string nom);
		Task<ContactEntity> GetByCampo1(int id_contact);
	}
}

