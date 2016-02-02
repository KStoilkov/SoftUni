namespace ExportFinishedGamesAsXml
{
    using EntityFrameworkMappings;
    using System.Linq;
    using System.Xml.Linq;

    public class FinishedGamesAsXml
    {
        static void Main()
        {
            var context = new DiabloContext();

            var finishedGames = context.Games
                .Where(g => g.IsFinished)
                .Select(g => new
                {
                    name = g.Name,
                    duration = g.Duration,
                    users = g.UsersGames.Select(ug => new
                    {
                        username = ug.User.Username,
                        ipAdress = ug.User.IpAddress
                    })
                });

            XElement gamesElement = new XElement("games");

            foreach (var game in finishedGames)
            {
                XElement gameElement = new XElement("game", new XAttribute("name", game.name));

                if (game.duration != null)
                {
                    gameElement.Add(new XAttribute("duration", game.duration));
                }

                XElement usersElement = new XElement("users");

                foreach (var user in game.users)
                {
                    XElement userElement = new XElement("user", new XAttribute("username", user.username),
                        new XAttribute("ip-address", user.ipAdress));

                    usersElement.Add(userElement);
                }

                gameElement.Add(usersElement);
                gamesElement.Add(gameElement);
            }

            gamesElement.Save("../../../finished-games.xml");
        }
    }
}
