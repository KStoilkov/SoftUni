namespace ImportUsersAndTheirGames
{
    using EntityFrameworkMappings;
    using System;
    using System.Linq;
    using System.Xml;

    public class ImportUsersAndTheirGames
    {
        static void Main()
        {
            var context = new DiabloContext();
            var dbUsers = context.Users.ToList();

            XmlDocument doc = new XmlDocument();
            doc.Load("../../../users-and-games.xml");
            
            XmlNodeList users = doc.SelectNodes("/users/user");

            foreach (XmlNode user in users)
            {
                string username = user.Attributes["username"].InnerText;

                var dbUser = dbUsers.FirstOrDefault(u => u.Username == username);
                if (dbUser != null)
                {
                    Console.WriteLine($"User {username} already exists");
                }
                else {
                    User currentUser = createUser(context, user, username);
                    addUserToGames(user, currentUser.Id, currentUser.Username, context);
                }
            }
        }

        private static void addUserToGames(XmlNode user, int userId, string username, DiabloContext context)
        {
            XmlNodeList userGames = user.SelectNodes("games/game");

            foreach (XmlNode userGame in userGames)
            {
                string gameName = userGame["game-name"].InnerText;
                XmlNode character = userGame.SelectSingleNode("character");
                string characterName = character.Attributes["name"].InnerText;
                decimal cash = decimal.Parse(character.Attributes["cash"].InnerText);
                int level = int.Parse(character.Attributes["level"].InnerText);
                DateTime joinedOn = DateTime.Parse(userGame["joined-on"].InnerText);

                int gameId = context.Games.FirstOrDefault(g => g.Name == gameName).Id;
                int characterId = context.Characters.FirstOrDefault(c => c.Name == characterName).Id;

                UsersGame currentUsersGame = new UsersGame
                {
                    GameId = gameId,
                    UserId = userId,
                    CharacterId = characterId,
                    Level = level,
                    JoinedOn = joinedOn,
                    Cash = cash
                };

                context.UsersGames.Add(currentUsersGame);

                Console.WriteLine($"User {username} successfully added to game {gameName}");
            }

            context.SaveChanges();
        }

        public static User createUser(DiabloContext context, XmlNode user, string username)
        {
            string firstName = null;
            string lastName = null;
            string email = null;
            DateTime registrationDate = DateTime.Parse(user.Attributes["registration-date"].InnerText);
            bool isDeleted = int.Parse(user.Attributes["is-deleted"].InnerText) != 0;
            string ipAddress = user.Attributes["ip-address"].InnerText;
                
            if (user.Attributes["first-name"] != null)
            {
                firstName = user.Attributes["first-name"].InnerText;
            }

            if (user.Attributes["last-name"] != null)
            {
                lastName = user.Attributes["last-name"].InnerText;
            }

            if (user.Attributes["email"] != null)
            {
                email = user.Attributes["email"].InnerText;
            }

            User currentUser = new User
            {
                Username = username,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                RegistrationDate = registrationDate,
                IsDeleted = isDeleted,
                IpAddress = ipAddress
            };
            
            context.Users.Add(currentUser);
            context.SaveChanges();

            Console.WriteLine($"Successfully added user {currentUser.Username}");
            return currentUser;
        }
    }
}
