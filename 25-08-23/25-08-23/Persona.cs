public abstract class Persona{
     private string nombre;
     private string apellido;

    private Persona(string nombre, string apellido){
        this.nombre = nombre;
        this.apellido = apellido;
    }
    public abstract void Presentarse();
}