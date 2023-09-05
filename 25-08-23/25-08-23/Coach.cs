public class Coach : Person {
    private Tactic tactic { get; set; }

    public Coach(){}

    public Coach (Tactic tactic , string nom, string apel) : base(nom, apel){
        this.tactic = tactic;
    }    
    
    public override void Introduce(){
        Console.WriteLine($"Mi nombre es {Name} {Surname} y mi tactica es {tactic}");
    }
    

}