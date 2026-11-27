namespace RemesaSmart.Api.Models
{
    public class Hogar
    {
        public int Id {get; set;}
        public string Nombre {get; set;} =string.Empty;
        public string Ciudad {get; set;} =string.Empty;
        public string CodigoPostal {get; set;} =string.Empty;
        public string NumeroVivienda {get; set;} =string.Empty;
        public string Calle {get;set;} =string.Empty;

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}