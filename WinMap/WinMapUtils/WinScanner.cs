using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;
using WinMapUtils;
using System.Runtime.Versioning;

namespace WinMapUtils
{
    [SupportedOSPlatform("windows")]
    public class WinScanner
    {
        public async static Task RunScan(string _ip1, int _timeout4)
        {
            await WinScan.ScanIP(_ip1, 6, 9);
        }

        public async static Task ScanSubnet(string _IPSUBNET)
        {
            // int _timeout59 = 1000;
            for (var _HOSTOCTET = 1; _HOSTOCTET <= 255; _HOSTOCTET++)
            {
                // Generate IP by appending host number.
                string _currentIP = $"{_IPSUBNET}.{_HOSTOCTET}";
                
                // Calls ping scan function //
                await WinMapUtils.WinScan.ScanIP(_currentIP, _HOSTOCTET, _HOSTOCTET);
                //Calls PingScan with the Generated IP SUBNET HOSTS i.e. [ENUMERATED IP HOSTS]

            }
        }
    }
}