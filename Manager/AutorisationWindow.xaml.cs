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
using System.Windows.Shapes;
using EntityLibrary.SerializableModels;
using MD5Library;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace Manager
{
    public partial class AutorisationWindow : Window
    {
        private readonly int ROLEID = 2; // Const of role manager

        public AutorisationWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = loginField.Text;
            string password = passwordField.Password;
            var hashPassword = Hasher.GetHash(password);

            // CAN be NULL
            SAccount result = await SendAsync($"Login;{login};{hashPassword}");

            if (result == null)
            {
                MessageBox.Show($"Логин или пароль неверный!",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.IsEnabled = false;
            }
        }

        private async Task<SAccount> SendAsync(string sendMessage)
        {
            return await Task.Run(() => Send(sendMessage));
        }

        private SAccount Send(string sendMessage)
        {
            int port = 10000;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(ip, port);
            TcpClient client = null;
            NetworkStream stream = null;
            BinaryFormatter bf = null;
            SAccount account = null;

            try
            {
                client = new TcpClient(ep);
                bf = new BinaryFormatter();
                stream = client.GetStream();
                byte[] data = System.Text.Encoding.UTF8.GetBytes(sendMessage);
                stream.Write(data, 0, data.Length);

                account = (SAccount)bf.Deserialize(stream);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка подключения: {err.Message}",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
            return account;
        }
    }
}
