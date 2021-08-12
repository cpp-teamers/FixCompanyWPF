using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Manager.View
{
    public partial class MainWindow : Window
    {
        const int port = 745;
      public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            IPAddress addr = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(addr, port);
            TcpClient client = null;
            try
            {
                //
                int senderId = 0; // !!!!!!!!!!!!!!!!!!!!!!!
                int receiverId = 0; // !!!!!!!!!!!!!!!!!!!!!!
                string sendMess = $"Mess;{DateTime.Now.ToString()};{smsText.Text};{senderId};{receiverId}";
                //
                client = new TcpClient();
                client.Connect(ep);
                NetworkStream ns = client.GetStream();
                StreamWriter sw = new StreamWriter(ns) { AutoFlush = true };
                sw.WriteLine(sendMess);
                sw.Flush();


                // Close all streams we used
                sw.Close();
                ns.Close();
                client.Close();
            }
            catch(Exception err) { }
        }
    }
}
