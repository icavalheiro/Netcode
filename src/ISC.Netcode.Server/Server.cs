using ISC.Netcode.Server.Tools;

namespace ISC.Netcode.Server;

/// <summary>
/// Class that handles everything related to the server and clients
/// </summary>
public class Server
{
    private readonly int? _tcpPort;
    private readonly int? _udpPort;
    private readonly int? _websocketPort;

    /// <summary>
    /// Get a new instance of a server with the specified protocol ports.
    /// If you don't want a protocol to be used, just send null as the port
    /// for that protocol.
    /// </summary>
    public Server(int? udpPort = null, int? tcpPort = null, int? websocketPort = null)
    {
        Validator.ValidateServerPortConfiguration(udpPort, tcpPort, websocketPort);

        (_tcpPort, _udpPort, _websocketPort) = (tcpPort, udpPort, websocketPort);
    }


    public void Start(CancellationToken ct)
    {

    }
}
