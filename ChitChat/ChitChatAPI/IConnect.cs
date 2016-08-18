﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChitChatAPI
{
    public interface IConnect
    {
        void Server(string server);
        void clientName(string uname);
        bool IsConnected(string client);
        bool IsDisconnected(string client);
        bool IsServerisdown(string server);
        bool IsRegistered(string Name);
        bool IsVisible(string uname);
        void statusMessage(string message,string uname);
        void database(string connectionstring);
        void ChangePassword(string uname, string oldpassword, string newpassword);

    }
}
