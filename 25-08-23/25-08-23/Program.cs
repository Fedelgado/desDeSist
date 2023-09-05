static void Main(string[] args) { 
    //address 
    Address clubAdress = new Address("Charlone", "CABA", 770);

    //players 
    Player player1 = new Player(10, "Juan", "Perez");
    Player player2 = new Player(23, "Sebastian", "Diaz");
    Player player3 = new Player(15, "Eitan", "Mohorade");
    Player player4 = new Player(6, "Francisco", "Trujillo");
    Player player5 = new Player(12, "Pedro", "Juarez");
    Player player6 = new Player(23, "Jorge", "Peñaranda");
    Player player7 = new Player(9, "Tobias", "Tamashiro");
    Player player8 = new Player(2, "Luciano", "Scerbo");
    Player player9 = new Player(1, "Fernando", "Villarreal");
    Player player10 = new Player(17, "Nicolas", "Jaime");

    //players list
    List<Player> players1 = new List<Player>(); 
    players1.Add(player1);
    players1.Add(player2);
    players1.Add(player3);
    players1.Add(player4);

    List<Player> players2 = new List<Player>(); 
    players2.Add(player5);
    players2.Add(player6);
    players2.Add(player7);

    List<Player> players3 = new List<Player>(); 
    players3.Add(player8);
    players3.Add(player9);
    players3.Add(player10);


    //coaches
    Coach coach1 =  new Coach(Tactic.OFENSIVE, "Francisco", "Heili");
    Coach coach2 =  new Coach(Tactic.DEFENSIVE, "Rolando", "Gimenez");
    Coach coach3 =  new Coach(Tactic.BALANCED, "Jacinto", "Lopez");
    
    //employees
    Employee employee1 = new Employee("technician", "Juan", "Casilla");
    Employee employee2 = new Employee("customer support", "Ezequiel", "Paredes");
    Employee employee3 = new Employee("website programmer", "Gabriel", "Longombardo");
    
    //list employees
    List<Employee> listEmployees = new List<Employee>();
    listEmployees.Add(employee1); 
    listEmployees.Add(employee2); 
    listEmployees.Add(employee3); 

    //teams
    Team team1 = new Team(Category.FIRST, players1, coach1);
    Team team2 = new Team(Category.FIRST, players2, coach2);
    Team team3 = new Team(Category.FIRST, players3, coach3);

    //list teams
    List<Team> listTeams = new List<Team>();
    listTeams.Add(team1);
    listTeams.Add(team2);
    listTeams.Add(team3);
    
    //club
    spClub ClubChacarita = new spClub("ChacaClub", clubAdress, 1977, listTeams, listEmployees);

}