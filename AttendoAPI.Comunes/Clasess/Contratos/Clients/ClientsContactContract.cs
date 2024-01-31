using System;
using AttendoAPI.Comunes.Clasess.Contratos.Contacts;

namespace AttendoAPI.Comunes.Clasess.Contratos.Clients
{
	public class ClientsContactContract
	{
        public int id { get; set; }
        public string CodCliente { get; set; } = string.Empty;
        public string NIF { get; set; } = string.Empty;
        public string NOMBRE1 { get; set; } = string.Empty;
        public string NOMBRE2 { get; set; } = string.Empty;
        public string EMAIL { get; set; } = string.Empty;
        public string TELEFONO { get; set; } = string.Empty;
        public string DIRECCION { get; set; } = string.Empty;
        public string CP { get; set; } = string.Empty;
        public string CIUDAD { get; set; } = string.Empty;
        public string CIUDAD2 { get; set; } = string.Empty;
        public ContactDTOContract? CONTACTO { get; set; }
    }
}

