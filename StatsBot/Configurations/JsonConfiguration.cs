using Newtonsoft.Json;

public struct JsonConfiguration
{
    [JsonProperty("token")]
    public string Token { get; private set; }

    [JsonProperty("prefix")]
    public string CommandPrefix { get; private set; }
}