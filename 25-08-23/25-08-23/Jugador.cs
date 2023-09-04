public class Jugador : Persona{
    private int dorsal {get; set;}
        public Jugador (int dorsal, string nom, string apel) : base(nom, apel){
        this.dorsal = dorsal;
    }
    public override void Presentarse(){
        Console.WriteLine($"Mi nombre es {nombre} {apellido} y tengo el numero {dorsal}");
    }

}