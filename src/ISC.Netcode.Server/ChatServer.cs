using ISC.Netcode.Server.Tools;

namespace ISC.Netcode.Server;

/// <summary>
/// Class that handles everything related to the server and clients
/// </summary>
public class ChatServer : IDisposable
{
    public void Dispose()
    { }

    /// <summary>
    /// Starts all server threads to listen sockets and handle tick events.
    /// </summary>
    /// <param name="ct">Token created from a CancellationTokenSource to request server stops after time.</param>
    public void Start(CancellationToken ct)
    {

    }
}
