using System;
public class Aguila : Aves // Herencia 
{
    public bool EsGrande { get; set; }
    public Aguila() // Polimorfismo
    {
        EsGrande = true;
    }
    public Aguila(bool esGrande)
    {
        EsGrande = esGrande;
    }
    public void VolarAlto() // Abstraccion 
    {
        Console.WriteLine("Volando Alto");
    }
}