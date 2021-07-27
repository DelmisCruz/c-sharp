using System;
public class Loro : Aves // Herencia
{
    public void Hablar() // Abstraccion 
    {
        Console.WriteLine("Hablando");
    }
    private void Color()
    {
        DescribirColor();
    }
    private void DescribirColor() // Encapsulamiento
    {
        Console.WriteLine("Es Verde");
    }
}