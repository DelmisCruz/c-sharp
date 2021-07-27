using System;
public class Gato : Mamiferos // Herencia 
{
    public bool EsGordo { get; set; }
    public Gato() //Polimorfismo
    {
        EsGordo = true;
    }
    public Gato(bool esGordo)
    {
        EsGordo = esGordo;
    }
    public void Maullar() // Abstraccion 
    {
        Console.WriteLine("Maullando");
    }

    private void Color()
    {
        DescribirColor();
    }
    private void DescribirColor() // Encapsulamiento 
    {
        Console.WriteLine("Es Amarillo");
    }

}