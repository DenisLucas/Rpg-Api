namespace RpgApi.Contracts.V1
{
    public class ApiRoutes
    {
        public const string version = "v1";
        public const string root = "api";
        public const string Base = root + "/" + version;
        
        public static class Player
        {
            public const string CreatePlayer = Base  + "/CreatePlayer/";
            public const string GetPlayerId = Base  + "/GetPlayerId/{id}";
            public const string GetPlayerName = Base  + "/GetPlayerName/{name}";
            public const string GetPlayerFullById = Base  + "/GetPlayerFullById/{id}";
            public const string GetPlayerFullByName = Base  + "/GetPlayerFullByName/{name}";
            public const string UpdatePlayerById = Base  + "/UpdatePlayerId/{id}";
            public const string UpdatePlayerByName = Base  + "/UpdatePlayerName/{name}";
            public const string DeletePlayerById = Base  + "/DeleyePlayerId/{id}";
            public const string DeletePlayerByName = Base  + "/DeletePlayerName/{name}";
        }
        public static class Itens
        {
            public const string CreateIten = Base  + "/CreateIten/";
            public const string GetItenId = Base  + "/GetItenId/{id}";
            public const string GetItenName = Base  + "/GetItenName/{name}";
            public const string UpdateItenById = Base  + "/UpdateItenId/{id}";
            public const string UpdateItenByName = Base  + "/UpdateItenName/{name}";
            public const string DeleteItenById = Base  + "/DeleyeItenId/{id}";
            public const string DeleteItenByName = Base  + "/DeleteItenName/{name}";
        }

        public static class Inventario
        {
            public const string AddIten = Base + "/AddIten/{itenId}/{userId}";
        }
    }
}