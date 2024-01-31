using AttendoAPI.Infraestructura.DataBase.Context;
using AttendoAPI.Infraestructura.DataBase.Entity;
using AttendoAPI.Infraestructura.Repositorios.Attendo.General;
using Microsoft.EntityFrameworkCore;

namespace AttendoAPI.Infraestructura.Repositorios.Attendo.Contactos
{
	public class ContactsRepository : IAttendoRepository<ContactEntity>, IContactsRepository
	{
		private readonly AttendoContext _context;
		public ContactsRepository(AttendoContext context)
		{
			_context = context;
		}

        public async Task<List<ContactEntity>> GetAll()
        {
            return await _context.Contact.ToListAsync();
        }

        public async Task<ContactEntity> GetByCampo1(int id_contact)
        {
            return await _context.Contact
                .FirstOrDefaultAsync(c => c.Campo1 == id_contact);
        }

        public async Task<ContactEntity> GetbyID(int id)
        {
            return await _context.Contact
                .FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<ContactEntity> GetByName(string nom)
        {
            return await _context.Contact
                .FirstOrDefaultAsync(c => c.Cliente == nom);
        }
    }
}

