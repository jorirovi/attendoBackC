using AttendoAPI.Comunes.Clasess.Constantes;
using AttendoAPI.Comunes.Clasess.Contratos.Contacts;
using AttendoAPI.Dominio.Attendo.General;
using AttendoAPI.Infraestructura.DataBase.Entity;
using AttendoAPI.Infraestructura.Repositorios.Attendo.Contactos;
using AttendoAPI.Infraestructura.Repositorios.Attendo.General;
using AutoMapper;

namespace AttendoAPI.Dominio.Attendo.Contacts
{
	public class ContactService : IAttendoService<ContactContract>, IContactService
	{
		private readonly IAttendoRepository<ContactEntity> _aRepository;
        private readonly IContactsRepository _contactR;
		private readonly IMapper _mapper;
		public ContactService(IAttendoRepository<ContactEntity> aRepository, IMapper mapper,
            IContactsRepository contactR)
		{
			_aRepository = aRepository;
            _contactR = contactR;
			_mapper = mapper;
		}

        public async Task<List<ContactContract>> GetAll()
        {
            List<ContactEntity> Contactos = await _aRepository.GetAll();
            return _mapper.Map<List<ContactContract>>(Contactos);
        }

        public async Task<ContactContract> GetById(int id)
        {
            ContactEntity contact = await _aRepository.GetbyID(id);
            if (contact != null)
            {
                return _mapper.Map<ContactContract>(contact);
            }
            else
            {
                throw new Exception(Constantes.registroNoEncontrado);
            }
        }

        public async Task<ContactContract> GetByName(string name)
        {
            ContactEntity contact = await _contactR.GetByName(name);
            if (contact != null)
            {
                return _mapper.Map<ContactContract>(contact);
            }
            else
            {
                throw new Exception(Constantes.registroNoEncontrado);
            }
        }
    }
}

