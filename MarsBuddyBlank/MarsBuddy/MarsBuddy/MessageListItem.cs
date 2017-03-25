using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace MarsBuddy
{
    class MessageListItem
    {
        public string Text { get; set; }
        public string Sender { get; set; }
        public MessageListItem(string text, string sender)
        {
            Text = text; Sender = sender;
        }

    }

}
