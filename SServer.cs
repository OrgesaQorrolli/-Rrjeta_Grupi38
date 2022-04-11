using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server is waiting for connections...");
            UdpClient client = new UdpClient(8080);

            IPEndPoint remoteip = new IPEndPoint(IPAddress.Any, 8080);

            byte[] receivedbytes = client.Receive(ref remoteip);


            if (receivedbytes != null)
            {

                string message = Encoding.ASCII.GetString(receivedbytes);
                Console.WriteLine("received message " + message);

            }


            else
            {
                Console.WriteLine("Empty message received!");
            }

                Console.ReadLine();


            }
        }}
