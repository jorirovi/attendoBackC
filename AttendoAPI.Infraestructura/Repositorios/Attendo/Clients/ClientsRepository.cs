using AttendoAPI.Infraestructura.DataBase.Context;
using AttendoAPI.Infraestructura.DataBase.Entity;
using AttendoAPI.Infraestructura.Repositorios.Attendo.General;
using Microsoft.EntityFrameworkCore;

namespace AttendoAPI.Infraestructura.Repositorios.Attendo.Clients
{
	public class ClientsRepository : IAttendoRepository<ClientsEntity>, IClientsRepository
	{
		private readonly AttendoContext _context;
		public ClientsRepository(AttendoContext context)
		{
			_context = context;
		}

        public async Task<List<ClientsEntity>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<ClientsEntity> GetbyID(int id)
        {
            return await _context.Clients
                .FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<ClientsEntity> GetByName(string name)
        {
            return await _context.Clients
                .FirstOrDefaultAsync(c => c.NOMBRE1 == name);
        }
    }
}

