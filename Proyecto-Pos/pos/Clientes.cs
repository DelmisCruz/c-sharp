public class Cliente: Persona
{
    public double Saldo { get; set; }
    
    public Cliente(int codigo, string nombre, string telefono, string direccion)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
    }
}