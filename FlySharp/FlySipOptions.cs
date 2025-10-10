namespace FlySharp;

public class FlySipOptions
{
    /// <summary>
    /// URL de base de l'API FlySip, propre au reseller.
    /// Exemple : https://resellerX.flysip.net
    /// </summary>
    public required string ProviderUrl { get; set; } = string.Empty;

    /// <summary>
    /// Login XML-RPC FlySip.
    /// </summary>
    public required string Username { get; set; } = string.Empty;

    /// <summary>
    /// Mot de passe XML-RPC FlySip.
    /// </summary>
    public required string Password { get; set; } = string.Empty;
}