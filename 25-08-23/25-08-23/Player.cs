public class Player : Person{
    private int dorsal {get; set;}

    public Player(){}
    public Player (int dorsal, string nom, string apel) : base(nom, apel){
        this.dorsal = dorsal;
    }

    public override void Introduce(){
        Console.WriteLine($"Mi nombre es {Name} {Surname} y tengo el numero {dorsal}");
    }

}