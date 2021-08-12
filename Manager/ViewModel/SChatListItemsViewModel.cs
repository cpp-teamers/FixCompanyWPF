using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ViewModel
{
    class SChatListItemsViewModel
    {
        public List<ChatListItems> CListItems = new List<ChatListItems>();
        public SChatListItemsViewModel()
        {

        }
        //{
        //    get
        //    {
        //        return new List<ChatListItems>
        //        {
        //            new ChatListItems() { ContactName = "User 1", LastMessageTime = "10:30 PM", Availability = "Online", Message="Check out new video uploaded just now!", NewMsgCount="5",  IsOnline=true},
        //            new ChatListItems() { ContactName = "User 2", LastMessageTime = "14:45 pm", Availability = "Offline", Message = "Its seems logical that the strategy of providing!"},
        //            new ChatListItems() { ContactName = "User 3", LastMessageTime = "06:18 am", Availability = "Offline", Message = "I remember everything mate. See you later", IsRead = false},// IsChatSelected=true,
        //            new ChatListItems() { ContactName = "User 4", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
        //            new ChatListItems() { ContactName = "User 5", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
        //            new ChatListItems() { ContactName = "User 6", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
        //            new ChatListItems() { ContactName = "User 7", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
        //            new ChatListItems() { ContactName = "User 8", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
        //            new ChatListItems() { ContactName = "User 9", LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false, IsOnline=true},
        //        };
        //    }
        //}
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
}
