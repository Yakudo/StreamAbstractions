# System.Net.Sockets.TestingHelpers
A library that provides abstractions for testing code using System.Net.Sockets.

## Usage

In .NET `System.IO.Stream`/`System.Net.Sockets.NetworkStream` classes do not implement any interfaces. This makes it impossible to mock them in order to test code relying on those classes.

This library provides an abstraction (interfaces) and wrapper-class for such scenario. Instead of using `Stream`/`NetworkStream` directly use provided interfaces (`IStream`/`INetworkStream`) in your code and wrap `Stream` into `StreamWrapper` and `NetworkStream` into `INetworkStream`.

```
   IStream stream = new StreamWrapper(stream);
   INetworkStream stream = new NetworkStreamWrapper(networkStream);

   // Stream become IStream 
   // NetworkStream become INetworkStream
   // This way you can easily mock it and use in tests.
```