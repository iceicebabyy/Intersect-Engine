﻿using System.Collections.Generic;

namespace Intersect.Client.UI.Game.Chat
{
    public class ChatboxMsg
    {
        private static List<ChatboxMsg> sGameMessages = new List<ChatboxMsg>();
        private string mMsg = "";
        private Framework.GenericClasses.Color mMsgColor;
        private string mTarget = "";

        public ChatboxMsg(string msg, Framework.GenericClasses.Color clr, string target = "")
        {
            mMsg = msg;
            mMsgColor = clr;
            mTarget = target;
        }

        public string GetMessage()
        {
            return mMsg;
        }

        public Framework.GenericClasses.Color GetColor()
        {
            return mMsgColor;
        }

        public string GetTarget()
        {
            return mTarget;
        }

        public static void AddMessage(ChatboxMsg msg)
        {
            sGameMessages.Add(msg);
        }

        public static List<ChatboxMsg> GetMessages()
        {
            return sGameMessages;
        }

        public static void ClearMessages()
        {
            sGameMessages.Clear();
        }
    }
}