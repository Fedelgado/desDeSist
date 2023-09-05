public class Employee : Person {
    private string function { get; set; }


    public Employee(){}
    public Employee (string func, string nom, string apel) : base(nom, apel){
        this.function = func;
    }
    
    public override void Introduce(){
        Console.WriteLine($"Mi nombre es {Name} {Surname} y mi function es {function}");
    }
    

}