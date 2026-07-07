using DiceGame.PlayerSpace;
namespace DiceGame.Game
{
    public interface IGame
    {
        List<Player> PlayerList { get; set; }
        Player PlayGame();
    }
}
