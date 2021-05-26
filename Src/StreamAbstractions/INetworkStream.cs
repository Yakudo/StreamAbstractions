namespace StreamAbstractions
{
    public interface INetworkStream : IStream
    {
        bool DataAvailable { get; }
    }
}