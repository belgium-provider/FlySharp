namespace FlySharp;

public class FlySipOptions(string providerUrl, string username, string password)
{
    /// <summary>
    /// URL de base de l'API FlySip, propre au reseller.
    /// Exemple : https://resellerX.flysip.net
    /// </summary>
    public string ProviderUrl { get; set; } = providerUrl;

    /// <summary>
    /// Login XML-RPC FlySip.
    /// </summary>
    public string Username { get; set; } = username;

    /// <summary>
    /// Mot de passe XML-RPC FlySip.
    /// </summary>
    public string Password { get; set; } = password;
}