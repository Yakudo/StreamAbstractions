using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace StreamAbstractions
{
    public class StreamWrapper : IStream
    {
        private readonly Stream _stream;

        public StreamWrapper(Stream stream)
        {
            _stream = stream;
        }

        public long Position
        {
            get => _stream.Position;
            set => _stream.Position = value;
        }

        public long Length => _stream.Length;

        public bool CanWrite => _stream.CanWrite;

        public bool CanTimeout => _stream.CanTimeout;

        public bool CanSeek => _stream.CanSeek;

        public bool CanRead => _stream.CanRead;

        public int ReadTimeout
        {
            get => _stream.ReadTimeout;
            set => _stream.ReadTimeout = value;
        }

        public int WriteTimeout
        {
            get => _stream.WriteTimeout;
            set => _stream.WriteTimeout = value;
        }

        public static Stream Synchronized(Stream stream) => Stream.Synchronized(stream);

        public IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) =>
            _stream.BeginRead(buffer, offset, count, callback, state);

        public IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) =>
            _stream.BeginWrite(buffer, offset, count, callback, state);

        public void Close() => _stream.Close();

        public void CopyTo(Stream destination) => _stream.CopyTo(destination);

        public void CopyTo(Stream destination, int bufferSize) => _stream.CopyTo(destination, bufferSize);

        public Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) => _stream.CopyToAsync(destination, bufferSize, cancellationToken);

        public Task CopyToAsync(Stream destination, int bufferSize) => _stream.CopyToAsync(destination, bufferSize);

        public Task CopyToAsync(Stream destination) => _stream.CopyToAsync(destination);

        public void Dispose() => _stream.Dispose();

        public int EndRead(IAsyncResult asyncResult) => _stream.EndRead(asyncResult);

        public void EndWrite(IAsyncResult asyncResult) => _stream.EndWrite(asyncResult);

        public void Flush() => _stream.Flush();

        public Task FlushAsync() => _stream.FlushAsync();

        public Task FlushAsync(CancellationToken cancellationToken) => _stream.FlushAsync(cancellationToken);

        public int Read(byte[] buffer, int offset, int count) => _stream.Read(buffer, offset, count);

        public Task<int> ReadAsync(byte[] buffer, int offset, int count) => _stream.ReadAsync(buffer, offset, count);

        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => _stream.ReadAsync(buffer, offset, count, cancellationToken);

        public int ReadByte() => _stream.ReadByte();

        public long Seek(long offset, SeekOrigin origin) => _stream.Seek(offset, origin);

        public void SetLength(long value) => _stream.SetLength(value);

        public void Write(byte[] buffer, int offset, int count) => _stream.Write(buffer, offset, count);

        public Task WriteAsync(byte[] buffer, int offset, int count) => _stream.WriteAsync(buffer, offset, count);

        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => _stream.WriteAsync(buffer, offset, count, cancellationToken);

        public void WriteByte(byte value) => _stream.WriteByte(value);
    }
}