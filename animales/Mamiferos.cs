using System;

public abstract class Mamiferos : Animal // Herencia
{
    public int Patas { get; set; }
    
    public void Caminar() // Abstraccion
    {
        Console.WriteLine("Caminando");
    }
}