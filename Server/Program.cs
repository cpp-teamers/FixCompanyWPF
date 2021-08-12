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
using EntityLibrary.Models;

namespace Server
{
    class Program
    {
        static int port = 745;
        static IPAddress addr = IPAddress.Parse("127.0.0.1");
        static IPEndPoint ep = new IPEndPoint(addr, port);
        static TcpListener listener = new TcpListener(ep);
        static BinaryFormatter bf = new BinaryFormatter();
        static GeneralRepository genRep = new GeneralRepository();
        //
        static void Main(string[] args)
        {
            listener.Start(10);
            TcpClient acceptor = null;

            while (true)
            {
                try
                {
                    acceptor = listener.AcceptTcpClient();
                    Task.Run(() => ConnectClient(acceptor));
                }
                catch (Exception err)
                {
                    Console.WriteLine($"Thread error: {err.Message}");
                }
            }
        }

        private static void ConnectClient(TcpClient acceptor)
        {
            NetworkStream ns = null;
            try
            {
                ns = acceptor.GetStream();
                byte[] data = new byte[1024];
                int receivesBytes = ns.Read(data, 0, data.Length);
                string requestString = Encoding.UTF8.GetString(data, 0, receivesBytes);

                var request = requestString.Split(';')[0];    // Take first element of Request (etc. "Login")

                switch (request) 
                {
                    case "Login":
                        SAccount acc = Login(requestString.Split(';'));
                        bf.Serialize(ns, acc);
                        break;
                    case "Mess":
                        var res = Mess(requestString.Split(';'));
                        byte[] sendData = Encoding.UTF8.GetBytes(res);
                        ns.Write(sendData, 0, sendData.Length);
                        break;
                    default:
                        Console.WriteLine("Request doesn`t exist");
                        break;
                }

            }
            catch(Exception err)
            {
                Console.WriteLine($"Connection Error: {err.Message}");
            }
            finally
            {
                if (ns != null)
                    ns.Close();
                if (acceptor != null)
                    acceptor.Close();
            }
        }

        static private string Mess(string[] request)
        {
            genRep.MesRepo.AddMessage(new Message()
            {
                Id = 0,
                TimeStamp = DateTime.Parse(request[1]),
                Content = request[2],
                FromAccountId = Int32.Parse(request[3]),
                ToAccountId = Int32.Parse(request[4])
            });
            return "Received";
        }

        static private SAccount Login(string[] request)
        {
            Account account = genRep.AccRepo.GetAccountByLogin(request[1]);
            if(account == null)
            {
                return new SAccount { Id = -1};
            }
            if (!account.Password.Equals(request[2]))
            {
                return new SAccount { Id = -1 };
            }
            //
            return new SAccount()
            {
                Id = account.Id,
                Login = account.Login,
                RoleId = account.RoleId
            }; ;
        }

    }
}
