using DiceGame.Game;
using DiceGame.PlayerSpace;
using DiceGame.DataLayer;

PlayerDataOps playerDataOps = new PlayerDataOps();

List<Player> players = new List<Player>();
Console.WriteLine("Introduceti nr de jucatori:");
int nbOfPOlayers = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < nbOfPOlayers; i++)
{
    Console.WriteLine("Introduceti numele jucatorului:");
    string playerName = Console.ReadLine();
    Player? player = playerDataOps.GetPlayerByName(playerName);
    if (player == null)
    {
        player = new Player(playerName);
        playerDataOps.AddPlayer(player);
    }
    players.Add(player);
}

IGame game = new MyDiceGame(players);

Player winner = game.PlayGame();
winner.AddWin();
playerDataOps.UpdatePlayer(winner);
Console.WriteLine("The winner is:{0} and has {1} total wins",
    winner.Name, winner.Wins);
