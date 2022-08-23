using System;
using ISC.Netcode.ServerSide.Tools;
using Xunit;

namespace ISC.Netcode.UnitTests.ServerSide.Tools;

public class Validator_Schema
{
    [Fact]
    public void ValidateServerPortConfiguration_Udp()
    {
        Validator.ValidateServerPortConfiguration(4000, null, null);
    }

    [Fact]
    public void ValidateServerPortConfiguration_Tcp()
    {
        Validator.ValidateServerPortConfiguration(null, 4000, null);
    }

    [Fact]
    public void ValidateServerPortConfiguration_WebSocket()
    {
        Validator.ValidateServerPortConfiguration(null, null, 4000);
    }

    [Fact]
    public void ValidateServerPortConfiguration_Couple()
    {
        Validator.ValidateServerPortConfiguration(2000, null, 4000);
    }

    [Fact]
    public void ValidateServerPortConfiguration_All()
    {
        Validator.ValidateServerPortConfiguration(2000, 5000, 4000);
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsRepeated()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(2000, 2000, null);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsNoProtocol()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(null, null, null);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidTcpNegative()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(-1, null, null);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidTcpOver()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(65535, null, null);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidUdpNegative()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(null, -1, null);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidUdpOver()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(null, 65535, null);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidWsNegative()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(null, null, -1);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidWsOver()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(null, null, 65535);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidMultiple()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(-1, null, 65535);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidMultiple2()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(-1, 4000, 65535);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidMultiple3()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(-1, -4000, 65535);
        });
    }

    [Fact]
    public void ValidateServerPortConfiguration_ThrowsInvalidMultiple4()
    {
        Assert.Throws<Exception>(() =>
        {
            Validator.ValidateServerPortConfiguration(-99999, 99999, 65535);
        });
    }
}