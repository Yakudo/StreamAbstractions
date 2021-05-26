namespace System.Net.Sockets.TestingHelpers
{
    public interface INetworkStream : IStream
    {
        bool DataAvailable { get; }
    }
}