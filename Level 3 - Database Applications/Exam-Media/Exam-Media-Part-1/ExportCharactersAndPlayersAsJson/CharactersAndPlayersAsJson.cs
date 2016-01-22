namespace ExportCharactersAndPlayersAsJson
{
    using EntityFrameworkMappings;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;

    public class CharactersAndPlayersAsJson
    {
        static void Main()
        {
            var context = new DiabloContext();

            var characters = context.Characters
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    name = c.Name,
                    playedBy = c.UsersGames.Select(ug => ug.User.Username)
                });

            string charactersJson = new JavaScriptSerializer().Serialize(characters);

            File.WriteAllText("../../../characters.json", charactersJson);
        }
    }
}
