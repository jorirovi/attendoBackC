using AttendoAPI.Comunes.Clasess.Contratos.Clients;
using AttendoAPI.Infraestructura.DataBase.Entity;
using AttendoAPI.Infraestructura.Repositorios.Attendo.General;
using AttendoAPI.Dominio.Attendo.General;
using AutoMapper;
using AttendoAPI.Infraestructura.Repositorios.Attendo.Clients;
using AttendoAPI.Comunes.Clasess.Constantes;
using AttendoAPI.Infraestructura.Repositorios.Attendo.Contactos;
using AttendoAPI.Comunes.Clasess.Contratos.Contacts;

namespace AttendoAPI.Dominio.Attendo.Clients
{
	public class ClientsService : IAttendoService<ClientsContract>, IClientsService
	{
		private readonly IAttendoRepository<ClientsEntity> _aRepository;
        private readonly IClientsRepository _clientsR;
        private readonly IContactsRepository _contactR;
		private readonly IMapper _mapper;
        private readonly IAttendoRepository<ContactEntity> _contactRepo;
		public ClientsService(IAttendoRepository<ClientsEntity> aRepository, IMapper mapper,
            IClientsRepository clientsR, IContactsRepository contactsR, IAttendoRepository<ContactEntity> contactRepo)
		{
			_aRepository = aRepository;
            _clientsR = clientsR;
            _contactR = contactsR;
			_mapper = mapper;
            _contactRepo = contactRepo;
		}

        public async Task<List<ClientsContract>> GetAll()
        {
            List<ClientsEntity> clientes = await _aRepository.GetAll();
            return _mapper.Map<List<ClientsContract>>(clientes);
        }

        public async Task<ClientsContract> GetById(int id)
        {
            ClientsEntity cliente = await _aRepository.GetbyID(id);
            if (cliente != null)
            {
                return _mapper.Map<ClientsContract>(cliente);
            }
            else
            {
                return new ClientsContract();
            }
        }

        public async Task<ClientsContactContract> GetClientesContact(string name)
        {
            ClientsEntity client = await _clientsR.GetByName(name);
            if (client != null)
            {
                ContactEntity contact = await _contactR.GetByCampo1(client.id);
                ClientsContactContract clientM = new ClientsContactContract()
                {
                    id = client.id,
                    CodCliente = client.CodCliente,
                    NIF = client.NIF,
                    NOMBRE1 = client.NOMBRE1,
                    NOMBRE2 = client.NOMBRE2,
                    EMAIL = client.EMAIL,
                    TELEFONO = client.TELEFONO,
                    DIRECCION = client.DIRECCION,
                    CP = client.CP,
                    CIUDAD = client.CIUDAD,
                    CIUDAD2 = client.CIUDAD2,
                    CONTACTO = new ContactDTOContract
                    {
                        id = contact.id,
                        Campo1 = contact.Campo1,
                        Cliente = contact.Cliente,
                        Telefono1 = contact.Telefono1,
                        Telefono2 = contact.Telefono2,
                        ClienteEmail = contact.ClienteEmail
                    }
                };
                return clientM;
            }
            else
            {
                throw new Exception(Constantes.registroNoEncontrado);
            }
        }

        public async Task<ClientsContract> GetClientsByName(string name)
        {
            ClientsEntity clients = await _clientsR.GetByName(name);
            if(clients != null)
            {
                return _mapper.Map<ClientsContract>(clients);
            }
            else
            {
                throw new Exception(Constantes.registroNoEncontrado);
            }
        }

        public async Task<List<ClientsContactContract>> GetlistClients()
        {
            List<ClientsEntity> listaClientes = await _aRepository.GetAll();
            List<ClientsContactContract> listadoMostrar = new List<ClientsContactContract>();
            foreach(ClientsEntity client in listaClientes)
            {
                ContactEntity contact = await _contactR.GetByCampo1(client.id);
                ClientsContactContract clienteContacto = new ClientsContactContract
                {
                    id = client.id,
                    CodCliente = client.CodCliente,
                    NIF = client.NIF,
                    NOMBRE1 = client.NOMBRE1,
                    NOMBRE2 = client.NOMBRE2,
                    EMAIL = client.EMAIL,
                    TELEFONO = client.TELEFONO,
                    DIRECCION = client.DIRECCION,
                    CP = client.CP,
                    CIUDAD = client.CIUDAD,
                    CIUDAD2 = client.CIUDAD2,
                    CONTACTO = new ContactDTOContract
                    {
                        id = contact.id,
                        Campo1 = contact.Campo1,
                        Cliente = contact.Cliente,
                        Telefono1 = contact.Telefono1,
                        Telefono2 = contact.Telefono2,
                        ClienteEmail = contact.ClienteEmail
                    }
                };
                listadoMostrar.Add(clienteContacto);
            }
            return listadoMostrar;
        }
    }
}

