using System;
using System.IO;

namespace DBSender.Classes
{
    public static class Logger
    {
        private static readonly Settings Settings = JsonFile.Settings;

        /// <summary>
        /// Add event log to summary
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="message"></param>
        public static void Add(MessageType messageType, string message)
        {
            if(!Settings.EnableLog) return;
            var dateTime = DateTime.Now.ToString("yyyyMMdd");
            var currentPath = JsonFile.AppDataPath + "\\LOGS";
            var logPath = currentPath + $"\\{dateTime}_.log";
            var fileStream = new FileStream(logPath, FileMode.Append, FileAccess.Write);

            if (fileStream.CanWrite)
            {
                var template = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + " [" + messageType + "] - " + message;
                var objStream = new StreamWriter(fileStream);
                objStream.WriteLine(template);
                objStream.Close();
                fileStream.Close();
            }
        }
    }

    /// <summary>
    /// Enumerators for the message type
    /// </summary>
    public enum MessageType
    {
        Error,
        Info
    }
}