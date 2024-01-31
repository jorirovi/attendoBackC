using AttendoAPI.Comunes.Clasess.Contratos.Clients;
using AttendoAPI.Comunes.Clasess.Contratos.Contacts;
using AttendoAPI.Infraestructura.DataBase.Entity;
using AutoMapper;

namespace AttendoAPI.Configuracion.Inicio
{
	public class PerfilAutoMapper : Profile
	{
		public PerfilAutoMapper()
		{
			CreateMap<ClientsEntity, ClientsContract>().ReverseMap();
			CreateMap<ContactEntity, ContactContract>().ReverseMap();
		}
	}
}

