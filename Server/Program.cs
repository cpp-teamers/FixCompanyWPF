using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.SerializableModels;
using EntityLibrary.Repositories.Implementations;

namespace Server
{
    class Program
    {
        static int port = 10000;
        static IPAddress addr = IPAddress.Parse("127.0.0.1");
        static IPEndPoint ep = new IPEndPoint(addr, port);
        static TcpListener listener = new TcpListener(ep);
        //static DataManager dm = new DataManager();
        static BinaryFormatter bf = new BinaryFormatter();
        //
        static void Main(string[] args)
        {
            listener.Start(10);
            try
            {
                while (true)
                {
                    TcpClient acceptor = listener.AcceptTcpClient();
                    NetworkStream ns = acceptor.GetStream();
                    byte[] data = new byte[256];
                    int receivesBytes = ns.Read(data, 0, data.Length);
                    string requestString = System.Text.Encoding.UTF8.GetString(data, 0, receivesBytes);
                    


                    //---------------------------------------
                    //---------------------------------------
                    Console.WriteLine("\n==========-|Success|-===============\n");
                    ns.Close();
                    acceptor.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"Thread error: {err.Message}");
            }
        }
    }
}
