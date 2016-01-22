namespace ImportUsersAndTheirGames
{
    using EntityFrameworkMappings;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    public class ImportUsersAndTheirGames
    {
        private static List<User> readedUsers = new List<User>();

        static void Main()
        {
            var context = new DiabloContext();
            var dbUsers = context.Users.ToList();

            XmlDocument doc = new XmlDocument();
            doc.Load("../../../users-and-games.xml");
            
            XmlNodeList users = doc.SelectNodes("/users/user");

            foreach (XmlNode user in users)
            {
                User currentUser = createUser(context, user, dbUsers);
                addUserToGames(user, currentUser.Id, currentUser.Username, context);
            }
        }

        private static void addUserToGames(XmlNode user, int userId, string username, DiabloContext context)
        {
            XmlNodeList userGames = user.SelectNodes("/games/game");

            foreach (XmlNode userGame in userGames)
            {
                string gameName = userGame.SelectSingleNode("game-name").Value;
                XmlNode character = userGame.SelectSingleNode("character");
                string characterName = character.Attributes["name"].InnerText;
                decimal cash = decimal.Parse(character.Attributes["cash"].InnerText);
                int level = int.Parse(character.Attributes["level"].InnerText);
                DateTime joinedOn = DateTime.Parse(userGame.SelectSingleNode("joined-on").Value);

                int gameId = context.Games.FirstOrDefault(g => g.Name == gameName).Id;
                int characterId = context.Characters.FirstOrDefault(c => c.Name == character.Name).Id;

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
        }

        public static User createUser(DiabloContext context, XmlNode user, List<User> dbUsers)
        {
            string username = user.Attributes["username"].InnerText;
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



            if (userExistsInDatabase(dbUsers, currentUser.Username))
            {
                context.Users.Add(currentUser);
                Console.WriteLine($"Successfully added user {currentUser.Username}");
                return currentUser;
            }
        }

        public static bool userExistsInDatabase(List<User> users, string username)
        {
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    return true;
                }
            }
        
            return false;
        }
    }
}
