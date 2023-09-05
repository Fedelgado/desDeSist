public class Team{
    private Category category;
    private List<Player> players;
    private Coach coach;

    public Team(){
    }

    public Team(Category category, List<Player> players, Coach coach){
        this.category = category;
        this.players = players;
        this.coach = coach;
    }


    public void addPlayer(Player player) {
        players.Add(player);
    }

    public void removePlayer(Player player) {
        players.Remove(player);  
    }
}