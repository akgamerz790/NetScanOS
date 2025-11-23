using System.Net.NetworkInformation;

namespace WinMapUtils
{
    public class WinScan
    {
        public static readonly int _timeout = 1000;
        public async static Task ScanIP(string _ip/*, int _timeout*/)
        {
            if (_ip == null)
            {
                Console.WriteLine("IP not supplied...");
                Console.ReadKey();
            }
            else
            {
                // using Ping ping = new Ping();
                using Ping ping = new();
                PingReply reply = ping.Send(_ip, _timeout);
            }
            
        }
    }
}