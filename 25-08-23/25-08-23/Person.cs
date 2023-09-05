public abstract class Person{
     private string name;
     private string surname; 
    public string Surname {get{return surname;} set{surname = value;} }
    public string Name {get{return name;} set{name = value;} }

    public Person(){}
    public Person(string name, string surname){
        this.name = name;
        this.surname = surname;
    }
    public abstract void Introduce();
}