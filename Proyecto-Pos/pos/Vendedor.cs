public class Vendedor: Persona
{
    public string CodigoVendedor { get; set; }
    
    public Vendedor(int codigo, string nombre, string telefono, string codigoVendedor)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        CodigoVendedor = codigoVendedor;
    }
}