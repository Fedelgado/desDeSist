public class spClub{
    private string name; 
    private Address address;
    private int foundationYear;
    private List<Team> teams;
    private List<Employee> admEmployees;

    public spClub(){
    }

    public spClub(string name, Address address, int foundationYear, List<Team> teams, List<Employee> admEmployees){
        this.name = name;
        this.address = address;
        this.foundationYear = foundationYear;
        this.teams = teams;
        this.admEmployees = admEmployees;
    }

    //teams
    public void addTeam(Team team){
        teams.Add(team);
    }
    public void removeTeam(Team team){
        teams.Remove(team);
    }


    //employees
        public void addEmployee(Employee employee){
        admEmployees.Add(employee);
    }
    public void removeEmployee(Employee employee){
        admEmployees.Remove(employee);
    }
}