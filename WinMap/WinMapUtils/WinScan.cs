using System;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using WinMapUtils;
using System.Runtime.Versioning;

namespace WinMapUtils
{
    [SupportedOSPlatform("windows")]
    public class WinScan
    {
        public static readonly int _timeout = 1000;
        public async static Task ScanIP(string _ip, int _port67, int _PORTOCHECK16)
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
                    if(reply.Status == IPStatus.Success){
                        await PortScan.CheckForPort(_ip, _port67);
                        await WinMap.WinScan.ScanSubnet(IPEncoder.GetSubnetBase(_ip));
                    }
                    else{
                        Tools.HostDOWN(_ip);
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

    public class Tools
    {
        public static void HostUP(string _ip)
        {
            bool _no = VariableSpace.FallBackVars._NEGATIVE;
            bool _yes = VariableSpace.FallBackVars._AFFIRMATIVE;
            WinUtils.WriteColored("[!] ", false, ConsoleColor.Blue, null);
            WinUtils.WriteColored("Host ", false, ConsoleColor.DarkCyan, null);
            WinUtils.WriteColored(_ip, _no, ConsoleColor.Green, null);
            WinUtils.WriteColored(" is up...", _yes, ConsoleColor.Red, null);
        }

        public static void HostDOWN(string _ip)
        {
            bool _no = VariableSpace.FallBackVars._NEGATIVE;
            bool _yes = VariableSpace.FallBackVars._AFFIRMATIVE;
            WinUtils.WriteColored("[!] ", false, ConsoleColor.Blue, null);
            WinUtils.WriteColored("Host ", false, ConsoleColor.DarkCyan, null);
            WinUtils.WriteColored(_ip, _no, ConsoleColor.Green, null);
            WinUtils.WriteColored(" is up...", _yes, ConsoleColor.Red, null);
        }
    }
}