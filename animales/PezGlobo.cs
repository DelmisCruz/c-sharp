using System;
public class PezGlobo : Peces // Herencia 
{
    public bool EsVenenoso { get; set; }
    public PezGlobo() // Polimorfismo
    {
        EsVenenoso = true;
    }
    public PezGlobo(bool esVenenoso) // Polimorfismo
    {
        EsVenenoso = esVenenoso;
    }
    public void Inflarce() // Abstraccion 
    {
        Console.WriteLine("Inflado");
    }
}