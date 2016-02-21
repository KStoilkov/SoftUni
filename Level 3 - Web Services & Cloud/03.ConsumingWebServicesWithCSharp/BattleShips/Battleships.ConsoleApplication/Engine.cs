namespace Battleships.ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public static class Engine
    {
        private static string baseUrl = "http://localhost:62859/";

        private static PlayerDTO playerDto = new PlayerDTO();

        public static void ParseCommand(string input)
        {
            if (input == string.Empty)
            {
                return;
            }

            string[] splittedInput = input.Split(
                new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = splittedInput[0];

            switch (command)
            {
                case "register":
                    Register(splittedInput);
                    break;
                case "login":
                    Login(splittedInput);
                    break;
                case "create-game":
                    CreateGame();
                    break;
                case "join-game":
                    JoinGame(splittedInput);
                    break;
                case "play":
                    PlayGame(splittedInput);
                    break;
                default:
                    Console.WriteLine("Invalid Command.");
                    break;
            }
        }

        private static async void PlayGame(string[] param)
        {
            if (param.Length != 4)
            {
                Console.WriteLine("Error: Play game requires 4 parameters.");
                return;
            }

            string gameId = param[1];
            string posX = param[2];
            string posY = param[3];

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", playerDto.TokenType + " " + playerDto.Token);

                string endpoint = baseUrl + "api/Games/play";

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("GameId", gameId),
                    new KeyValuePair<string, string>("PositionX", posX),
                    new KeyValuePair<string, string>("PositionY", posY)
                });

                var response = await httpClient.PostAsync(endpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine($"Successfully attacked at position ({posX}, {posY})");
                }
            }
        }

        private static async void JoinGame(string[] param)
        {
            if (param.Length != 2)
            {
                Console.WriteLine("Error: Join game requires 2 parameters.");
                return;
            }

            string gameId = param[1];

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", playerDto.TokenType + " " + playerDto.Token);

                string endpoint = baseUrl + "api/Games/join";

                var content = new FormUrlEncodedContent(new[] 
                {
                    new KeyValuePair<string, string>("GameId", gameId)
                });

                var response = await httpClient.PostAsync(endpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("Message: Successfully joined in game: " + gameId);
                }
            }
        }

        private static async void CreateGame()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", playerDto.TokenType + " " + playerDto.Token);

                string endpoint = baseUrl + "api/Games/create";
                
                var response = await httpClient.PostAsync(endpoint, null);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("Game created");
                }
            }
        }

        private static async void Login(string[] param)
        {
            if (param.Length != 3)
            {
                Console.WriteLine("Error: Login requires 3 parameters");
                return;
            }

            string username = param[1];
            string pass = param[2];

            using (var httpClient = new HttpClient())
            {
                string endpoint = baseUrl + "Token";

                var content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("Username", username),
                        new KeyValuePair<string, string>("Password", pass),
                        new KeyValuePair<string, string>("grant_type", "password")
                });

                var response = await httpClient.PostAsync(endpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(error);
                }
                else
                {
                    playerDto = await response.Content.ReadAsAsync<PlayerDTO>();
                    Console.WriteLine("Message: Successfully logged in.");
                }
            }
        }

        private static async void Register(string[] param)
        {
            if (param.Length != 4)
            {
                Console.WriteLine("Error: Register requires 4 parameters.");
                return;
            }

            string email = param[1];
            string pass = param[2];
            string confirmPass = param[3];

            if (pass != confirmPass)
            {
                Console.WriteLine("Error: Password do not match.");
                return;
            }

            using (var httpClient = new HttpClient())
            {
                string endpoint = baseUrl + "api/Account/Register";

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("Email", email),
                    new KeyValuePair<string, string>("Password", pass),
                    new KeyValuePair<string, string>("ConfirmPassword", confirmPass)
                });

                var response = await httpClient.PostAsync(endpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("Message: Successfully registered " + email);
                }
            }
        }
    }
}
