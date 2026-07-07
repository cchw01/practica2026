using DiceGame.DiceDBContext;
using DiceGame.PlayerSpace;

namespace DiceGame.DataLayer
{
    public class PlayerDataOps
    {
        private readonly DiceDBContextClass dataContext;
        public PlayerDataOps()
        {
            dataContext = new DiceDBContextClass();
        }

        public Player[] GetPlayers()
        {
            return dataContext.Players.ToArray();
        }

        public Player? GetPlayerByName(string playerName)
        {
            return dataContext.Players.SingleOrDefault(
                x=>x.Name == playerName);
        }
           
        public void AddPlayer(Player player)
        {
            try
            {
                dataContext.Players.Add(player);
                dataContext.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(
                    "Error adding player to database: {0}", ex.Message);
            }
        }

        public void DeletePlayer(Player player)
        {
            try
            {
                dataContext.Players.Remove(player);
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Error deleting player from database: {0}", ex.Message);
            }
        }

        public void UpdatePlayer(Player player)
        {
            try
            {
                dataContext.Players.Update(player);
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Error updating player in database: {0}", ex.Message);
            }
        }

    }
}
