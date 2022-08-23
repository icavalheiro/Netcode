using Xunit;
using System;
using ISC.Netcode.ServerSide;
using System.Threading;
namespace ISC.Netcode.UnitTests.ServerSide;

public class Server_Schema
{
    [Fact]
    public void CanDispose()
    {
        Server server = new(3000, null, null);
        server.Dispose();
    }

    [Fact]
    public void CanStartWithCt()
    {
        Server server = new(websocketPort: 1000);

        CancellationTokenSource ctSource = new();
        var ct = ctSource.Token;

        server.Start(ct);

        ctSource.Cancel();
    }
}