using System;
namespace AttendoAPI.Comunes.Clasess.Contratos.Clients
{
	public class ClientsContract
	{
        public int id { get; set; }
        public string CodCliente { get; set; } = string.Empty;
        public string NIF { get; set; } = string.Empty;
        public int NOSE1 { get; set; }
        public string NOSE2 { get; set; } = string.Empty;
        public string NOSE3 { get; set; } = string.Empty;
        public string NOMBRE1 { get; set; } = string.Empty;
        public string NOMBRE2 { get; set; } = string.Empty;
        public string EMAIL { get; set; } = string.Empty;
        public string TELEFONO { get; set; } = string.Empty;
        public string DIRECCION { get; set; } = string.Empty;
        public string CP { get; set; } = string.Empty;
        public string CIUDAD { get; set; } = string.Empty;
        public string CIUDAD2 { get; set; } = string.Empty;
        public string NOSE4 { get; set; } = string.Empty;
        public string NOSE5 { get; set; } = string.Empty;
        public DateTime FECHA1 { get; set; }
        public DateTime FECHA2 { get; set; }
        public int NOSE6 { get; set; }
        public int NOSE7 { get; set; }
    }
}

