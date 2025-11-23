using WinMapUtils;
using System.Runtime.Versioning;

namespace WinMap
{
    [SupportedOSPlatform("windows")]
    public class WinScan
    {
        public static async Task Main()
        {
            await Logo.Banner();
            await WinMapUtils.WinScan.ScanIP("127.0.0.1", 1000);
            Console.ReadKey();
        }
    }
}
