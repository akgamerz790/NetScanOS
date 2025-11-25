using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using WinMapUtils;

namespace WinMapUtils
{
    public class WinScan
    {
        public static readonly int _timeout = 1000;
        public async static Task ScanIP(string _ip/*, int _timeout*/, int _port67)
        {
            if (_ip == null)
            {
                Console.WriteLine("[!] Null Possible value supplied...");
            }
            else
            {
                int _timeout5 = 1000;
                try{
                    bool _no = VariableSpace.FallBackVars._NEGATIVE;
                    bool _yes = VariableSpace.FallBackVars._AFFIRMATIVE;
                    Ping ping = new();
                    PingReply reply = ping.Send(_ip, _timeout5);
                    // Console.WriteLine(reply.Status);
                    // Console.WriteLine(ping);
                    if(reply.Status == IPStatus.Success){
                        WinUtils.WriteColored("[!] ", false, ConsoleColor.Blue, null);
                        WinUtils.WriteColored("Host ", false, ConsoleColor.DarkCyan, null);
                        WinUtils.WriteColored(_ip, _no, ConsoleColor.Green, null);
                        WinUtils.WriteColored(" is up...", _yes, ConsoleColor.Red, null);
                        // Console.WriteLine("[!] Host " + _ip + " is up..." );
                        await PortScan.CheckForPort(_ip, _port67);
                        
                    }
                    else{
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
}