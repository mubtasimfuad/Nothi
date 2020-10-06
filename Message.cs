using System;
using System.Collections.Generic;
using System.Text;

namespace Nothi_Next
{
    public class Message
    {
        public string Source { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }

        public string Reciver { get; set; }
        public string Decision { get; set; }

        public Message(string source, string sender, string subject, string reciver, string decision)
        {
            Source = source;
            Sender = sender;
            Reciver = reciver;
            Subject = subject;
            Decision = decision;
        }
    }
}
