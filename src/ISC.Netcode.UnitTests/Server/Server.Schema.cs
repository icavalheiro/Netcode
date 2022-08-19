using Xunit;
using ISC.Netcode.Server;

namespace ISC.Netcode.UnitTests.Server;

public class Server_Schema
{
    [Fact]
    public void CanDispose()
    {
        MainServer server = new(3000, null, null);
        server.Dispose();
    }
}