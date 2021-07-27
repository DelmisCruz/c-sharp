using System;
public class Perro : Mamiferos // Herencia 
{
    public bool  EsFiel { get; set; }
    public Perro() // Polimorfismo
    {
        EsFiel = true;
    }
    public Perro(bool esFiel)
    {
        EsFiel = esFiel;
    }
    public void Ladrar() // Abstraccion 
    {
        Console.WriteLine("Ladrando");
    }
    private void Ladrido() // Encapsulamiento 
    {
        DescribirLadrido();
    }
    private void DescribirLadrido()
    {
        Console.WriteLine("Es fuerte");
    }
}