using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using VariableSpace;
using WinMapUtils;

namespace WinMapUtils
{
    public class ToolKitX
    {
        public static string _text = "[!] Local IP: ";
        public static string _text2 = "[!] Local Gateway IP: ";
        public static string _filler = "                                         ";
        public async static Task DisplayToolkit()
        {
            
            WinUtils.LineBreak();
            Console.Write(_text);
            Console.Write("127.0.0.1");
            Console.Write(_filler);
            Console.Write(_text2 + WinUtils.GetLocalIPAddress());
            Console.Write("\n" + "\n");
        }
    }

    class HandyUtils
    {
        private static void Nonce()
        {
            Console.WriteLine("=== IP Address Check ===");
            
            // Always returns 127.0.0.1 but checks network internally
            // string localhost = WinUtils.GetLocalhostIP();
            // Console.WriteLine($"Localhost IP: {localhost}");
            
            // Get real network IP if available
            // string networkIP = WinUtils.GetNetworkIPWithLocalhostFallback();
            // Console.WriteLine($"Network IP: {networkIP}");
            
            // Check what kind of IP we have
            // bool isRealNetwork = WinUtils.IsRealNetworkIP(networkIP);
            // Console.WriteLine($"Is real network IP: {isRealNetwork}");
        }
    }

    public class TextUtils
    {
        public async static Task TextStyler(string _ipT, string _ScanType, /*DateTime _timestamp1,*/ int _threadCount, int _portCountSpecified)
        {
            DateTime _timestamp1 = FallBackVars._NOW;
            Console.Write("[+] Target     : " + _ipT);
            WinUtils.LineBreak();
            Console.Write("[+] Scan Type  : " + _ScanType);
            WinUtils.LineBreak();
            Console.Write("[+] Threads    : " + _threadCount);
            WinUtils.LineBreak();
            Console.Write("[+] Ports      : " + _portCountSpecified);
            WinUtils.LineBreak();
            Console.Write("[+] Time       : " + _timestamp1);
            WinUtils.LineBreak();
        }
    }
}