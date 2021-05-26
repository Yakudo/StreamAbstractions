using System.Net.Sockets;

namespace StreamAbstractions
{
    public class NetworkStreamWrapper : StreamWrapper, INetworkStream
    {
        private readonly NetworkStream _stream;

        public NetworkStreamWrapper(NetworkStream stream) : base(stream)
        {
            _stream = stream;
        }

        public bool DataAvailable => _stream.DataAvailable;
    }
}