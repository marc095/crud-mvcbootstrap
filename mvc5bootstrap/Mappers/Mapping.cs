using mvc5bootstrap.Models;

namespace mvc5bootstrap.Mappers
{
    public static class Mapping
    {
        public static Player Map(PlayerViewModel playerVM)
        {
            return new Player()
            {
                PLayerID = playerVM.PlayerID,
                Age = playerVM.Age,
                Name = playerVM.Name,
                SurName = playerVM.SurName,
                TeamID = playerVM.TeamID
            };
        }

        public static PlayerViewModel Map(Player player)
        {
            return new PlayerViewModel()
            {
                PlayerID = player.PLayerID,
                Age = player.Age,
                Name = player.Name,
                SurName = player.SurName,
                TeamID = player.TeamID
            };
        }
    }
}