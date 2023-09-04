public class Empleado : Persona {
    private string funcion { get; set; }
        public override void Presentarse(){
        Console.WriteLine($"Mi nombre es {nombre} {apellido} y mi funcion es {funcion}");
    }
    
    public Empleado (string func, string nom, string apel) : base(nom, apel){
        this.funcion = func;
    }

}