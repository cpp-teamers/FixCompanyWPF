using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EntityLibrary.Models;

namespace Manager.ViewModel
{
    public class SMessageViewModel : INotifyPropertyChanged
    {
        public List<ChatListItems> ChatListItems
        {
            get
            {
                return new List<ChatListItems>
                {
                    new ChatListItems() { ContactName = "User 1", LastMessageTime = "10:30 PM", Availability = "Online", Message="Check out new video uploaded just now!", NewMsgCount="5",  IsOnline=true},
                    new ChatListItems() { ContactName = "User 2", LastMessageTime = "14:45 pm", Availability = "Offline", Message = "Its seems logical that the strategy of providing!"},
                    new ChatListItems() { ContactName = "User 3", LastMessageTime = "06:18 am", Availability = "Offline", Message = "I remember everything mate. See you later", IsRead = false},// IsChatSelected=true,
                    new ChatListItems() { ContactName = "User 4", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
                    new ChatListItems() { ContactName = "User 5", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
                    new ChatListItems() { ContactName = "User 6", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
                    new ChatListItems() { ContactName = "User 7", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
                    new ChatListItems() { ContactName = "User 8", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
                    new ChatListItems() { ContactName = "User 9", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
                };
            }
        }
        public List<Message> Messages
        {
            get
            {
                return new List<Message>
                {
                    new Message(){ Content="Hi Alex! What's Up?", HasRead=true, TimeStamp=DateTime.Now },
                    new Message() { Content="I remeber everything mate. See you later", HasRead=true, TimeStamp=DateTime.Now},
                    new Message() { Content="See you later ", HasRead=true, TimeStamp=DateTime.Now}
                };
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}