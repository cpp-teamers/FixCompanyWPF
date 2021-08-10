using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

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
            //static List<SStudent> students = new List<SStudent>();
            //static List<SFaculty> faculties = new List<SFaculty>();
            //static List<Message> messages = new List<Message>();
            static void Main(string[] args)
            {
                listener.Start(10);
                try
                {
                    while (true)
                    {
                        string request = "";
                        TcpClient acceptor = listener.AcceptTcpClient();
                        NetworkStream ns = acceptor.GetStream();

                        StreamReader sr = new StreamReader(ns);

                        //---------------------------------------
                        request = sr.ReadLine();
                        //---------------------------------------
                        Console.WriteLine("\n==========-|Success|-===============\n");
                        sr.Close();
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
