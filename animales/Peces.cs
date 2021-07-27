using System;

public abstract class Peces : Animal // Herencia 
{
    public int NumerodeAletas { get; set; }
    public void Nadar() // Abstraccion 
    {
        Console.WriteLine("Nadando");
    }
}