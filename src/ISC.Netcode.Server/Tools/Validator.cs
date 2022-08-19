namespace ISC.Netcode.Server.Tools;

public static class Validator
{
    public static void ValidateServerPortConfiguration(int? udpPort, int? tcpPort, int? websocketPort)
    {
        if (udpPort != null && (udpPort < 0 || udpPort >= 65535))
        {
            throw new Exception("Invalid port range for UDP, leave it null if you don't want a UDP server.");
        }

        if (tcpPort != null && (tcpPort < 0 || tcpPort >= 65535))
        {
            throw new Exception("Invalid port range for TCP, leave it null if you don't want a TCP server.");
        }

        if (websocketPort != null && (websocketPort < 0 || websocketPort >= 65535))
        {
            throw new Exception("Invalid port range for Websocket TCP, leave it null if you don't want a Websocket TCP server.");
        }

        if (udpPort == null && tcpPort == null && websocketPort == null)
        {
            throw new Exception("Please define at least one server you want to run, either Websocket, TCP or UDP.");
        }

        if ((udpPort != null && tcpPort != null && udpPort == tcpPort)
        || (udpPort != null && websocketPort != null && udpPort == websocketPort)
        || (tcpPort != null && websocketPort != null && tcpPort == websocketPort))
        {
            throw new Exception("You cannot have 2 or more sockets sharing the same port.");
        }
    }
}