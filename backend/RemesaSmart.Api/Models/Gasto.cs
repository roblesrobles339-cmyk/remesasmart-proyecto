using RemesaSmart.Api.Models;
public class Gasto
{
    public int Id {get; set;}
    public string Descripcion {get; set;} = string.Empty;
    public decimal Monto {get; set;}
    public int CategoriaId {get; set;}
    public Categoria? Categoria {get; set;}

    public DateTime Fecha {get; set;}
}
