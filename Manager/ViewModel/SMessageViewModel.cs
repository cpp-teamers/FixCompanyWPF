using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EntityLibrary.Models;
using Manager.Commands;

namespace Manager.ViewModel
{
    public class SMessageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Message> _messages;
        public ObservableCollection<Message> Messages
        {
            get { return _messages; }
            set
            {
                if (value != _messages)
                {
                    _messages = value;
                    OnPropertyChanged("Messages");
                }
            }
        }
        public SMessageViewModel()
        {
            _messages = new ObservableCollection<Message>();
            LoadMessages();
        }
        private void LoadMessages()
        {
            Messages.Add(new Message() { Content = "Hi, how are you doing?", HasRead = true, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "I'm fine. How about yourself?", HasRead = false, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "I'm pretty good. Thanks for asking.", HasRead = true, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "No problem. So how have you been?", HasRead = false, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "I've been great. What about you?", HasRead = true, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "I've been good. I'm in school right now.", HasRead = false, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "What school do you go to?", HasRead = true, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "I go to PCC.", HasRead = false, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "Do you like it there?", HasRead = true, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "It's okay. It's a really big campus.", HasRead = false, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "Good luck with school.", HasRead = true, TimeStamp = DateTime.Now });
            Messages.Add(new Message() { Content = "Thank you very much.", HasRead = false, TimeStamp = DateTime.Now });


            //OnPropertyChanged("Messages");
        }

        // -------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}