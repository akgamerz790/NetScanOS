using System.Net.NetworkInformation;

namespace WinMapUtils
{
    public class WinScan
    {
        public static readonly int _timeout = 1000;
        public async static Task ScanIP(string _ip/*, int _timeout*/)
        {
            try{
                Ping ping = new();
                PingReply reply = ping.Send(_ip, 1000);
                // Console.WriteLine(reply.Status);
                // Console.WriteLine(ping);
                if(reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("[!] Host " + _ip + " is up..." );
                }
                else
                {
                    Console.WriteLine("[!] Host " + _ip + " is down..." );
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            
        }
    }
}