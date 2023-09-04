public class Entrenador : Persona {
    private Tactica tactica { get; set; }

    public override void Presentarse(){
        Console.WriteLine($"Mi nombre es {nombre} {apellido} y mi tactica es {tactica}");
    }
    public Entrenador (Tactica tactica , string nom, string apel) : base(nom, apel){
        this.tactica = tactica;
    }    

}