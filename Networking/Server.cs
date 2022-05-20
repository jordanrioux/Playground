using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace Networking;

public class Server
{
    private TcpListener _listener;

    public int Port { get; set; }
    
    public Server(int port)
    {
        Port = port;
        _listener = TcpListener.Create(Port);
    }

    public async Task Start()
    {
        _listener.Start();
        Console.WriteLine($"Server has started on port {Port}!");
        
        while (true)
        {
            var client = await _listener.AcceptTcpClientAsync();
            new Thread(() => HandleRequest(client)).Start();
        }
    }

    private byte[] ReceiveAll(Socket socket, int bufferSize = 128)
    {
        var buffer = new List<byte>();
        while (socket.Available > 0)
        {
            var currentBufferBytes = new byte[bufferSize];
            var bytesCounter = socket.Receive(currentBufferBytes, currentBufferBytes.Length, SocketFlags.None);
            if (bytesCounter > 0)
            {
                buffer.AddRange(currentBufferBytes);
            }
        }
        return buffer.ToArray();
    }
    private void HandleRequest(TcpClient client)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        
        //Thread.Sleep(50);
        var stream = client.GetStream();
        var socket = stream.Socket;
        //var buffer = new byte[socket.Available];
        //stream.Read(buffer, 0, buffer.Length);
        
        //var buffer = ReceiveAll(socket);
        var i = 0;
        var bytes = new byte[8];
        var data = "";
        //while()
        do
        {
            try
            {
                i = stream.Read(bytes, 0, bytes.Length);
                Console.WriteLine("Seriously?: {0}", i);
                Console.WriteLine("Can Read: " + stream.CanRead);
                Console.WriteLine("DataAvailable: " + stream.DataAvailable);
                Console.WriteLine("Available: " + socket.Available);
            }
            catch (Exception e)
            {
                Console.WriteLine("LOL: " + e);
                throw;
            }
            
            
            var partialData = Encoding.UTF8.GetString(bytes);
            data += partialData;
        } while (stream.CanRead);

        Console.WriteLine(data);
        Console.WriteLine("Done!");

        var response = $"HTTP/1.1 200 OK\r\n";
        response += "Content-Length: 9\r\n";
        response += "Content-Type: text/html\r\n";
        response += "Connection: close\r\n";
        response += "\r\n";
        response += "It works!\r\n";
        
        var responseBytes = Encoding.UTF8.GetBytes(response);
        socket.Send(responseBytes);

        stopwatch.Stop();
        double ticks = stopwatch.ElapsedTicks;
        double milliseconds = (ticks / Stopwatch.Frequency) * 1000;
        Console.WriteLine("Request took " + milliseconds + "ms");
    }

    
}