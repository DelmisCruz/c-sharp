
//propiedades para mi objeto
public class Alumno 
{
    public int Id { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }


//Constructor (Inializa valores)
    public Alumno(){
        Id = 1;
    }

    public Alumno(int id){
        Id = id;
    }
}
