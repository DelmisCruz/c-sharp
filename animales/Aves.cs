using System;

public abstract class Aves : Animal // Herencia
{
    public string ColorPlumaje { get; set; }

    public void Volar() // Abstraccion 
    {
        Console.WriteLine("Volando");
    }
}