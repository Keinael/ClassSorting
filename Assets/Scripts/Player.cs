public class Player
{
    public string Name { get; set; }
    public int Coins { get; private set; }
    public int Points { get; private set; }
    public int Health { get; private set; }

    public Player(string name, int coins, int points, int health)
    {
        Name = name;
        Coins = coins;
        Points = points;
        Health = health;
    }
}