using System;
namespace AttendoAPI.Comunes.Clasess.Contratos.Contacts
{
	public class ContactDTOContract
	{
        public int id { get; set; }
        public int? Campo1 { get; set; }
        public string? Cliente { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? ClienteEmail { get; set; }
    }
}

