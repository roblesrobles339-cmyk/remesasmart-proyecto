using RemesaSmart.Api.Models;

namespace RemesaSmart.Api.Models
{
    public class Usuario
    {
        public int Id {get; set;} 
    public string Nombre {get; set;} =string.Empty;
    public string Apellido {get; set;} =string.Empty;
    public string Correo {get; set;} =string.Empty;
    public string PasswordHash {get; set;} =string.Empty;
    public DateTime FechaNacimiento {get; set;}
    public int HogarId {get; set;}
    public Hogar? Hogar {get; set;}    
    }
}