﻿namespace Battleships.ConsoleApplication
{
    using Newtonsoft.Json;

    public class PlayerDTO
    {
        [JsonProperty("access_token")]
        public string Token { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        public string Username { get; set; }
    }
}
