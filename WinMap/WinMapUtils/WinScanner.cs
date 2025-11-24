using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;
using WinMapUtils;

namespace WinMapUtils
{
    public class WinScanner
    {
        public async static Task RunScan(string _ip1, int _timeout4)
        {
            await WinScan.ScanIP(_ip1);
        }
    }
}