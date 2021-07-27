 using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            p.Nombre = "Layla";
            p.Patas = 4;
            p.EsFiel = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            

            Gato g = new Gato();
            g.Nombre = "Bigotes";
            g.Patas = 4;
            g.EsGordo = true;
            g.Comer();
            g.Caminar();
            g.Maullar();

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);

            Aguila a = new Aguila();
            a.Nombre = "Agui";
            a.EsGrande = true;
            a.Volar();
            a.Comer();

            Console.WriteLine(a.Nombre);

            Loro l = new Loro();
            l.Nombre = "Pancho";
            l.Volar();
            l.Comer();

            Console.WriteLine(l.Nombre);


            PezGlobo z = new PezGlobo();
            z.Nombre = "Bruno";
            z.NumerodeAletas = 2;
            z.EsVenenoso = true;
            z.Inflarce();
            z.Comer();
            z.Nadar();

            Console.WriteLine(z.Nombre);
            Console.WriteLine(z.NumerodeAletas);

            Mono m = new Mono();
            m.Nombre = "Coqui";
            m.Patas = 4;
            m.Maullar();
            m.Comer();
            m.Caminar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);


        }
    }
}
