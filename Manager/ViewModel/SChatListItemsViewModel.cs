using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ViewModel
{
    class SChatListItemsViewModel : INotifyPropertyChanged
    {
        public List<ChatListItems> ChatListItems
        {
            get
            {
                return new List<ChatListItems>
                {
                    new ChatListItems() { ContactName = "Dima", LastMessageTime = "10:30 PM", Availability = "Online", Message="Check it", NewMsgCount="5",  IsOnline=true, IsChatSelected=true},
                    new ChatListItems() { ContactName = "Sasha", LastMessageTime = "14:45 pm", Availability = "Offline", Message = "I don't know"},
                    new ChatListItems() { ContactName = "Lera", LastMessageTime = "06:18 am", Availability = "Offline", Message = "See you", IsRead = false},
                    new ChatListItems() { ContactName = "Maks", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "Bye", IsRead = false, IsOnline=true}
                };
           }
        }
        public ChatListItems _selectedChatListItem;
        public ChatListItems SelectedChatListItem
        { 
            get { return _selectedChatListItem; }
            set { _selectedChatListItem = value; OnPropertyChanged("SelectedChatListItem"); }
        }
        // -------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
    public class ChatListItems
        {
            public bool IsChatSelected { get; set; }

            public bool IsOnline { get; set; }

            public string ContactName { get; set; }

            public string LastMessageTime { get; set; }

            public string Availability { get; set; }

            public bool IsRead { get; set; }

            public string Message { get; set; }

            public string NewMsgCount { get; set; }
        }
}
