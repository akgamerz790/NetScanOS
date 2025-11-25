using WinMapUtils;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using VariableSpace;

namespace WinMap
{
    [SupportedOSPlatform("windows")]
    public class WinScan
    {
        public static async Task Main()
        {
            Console.WriteLine(FallBackVars._IS_LINUX);
            Banner.ShowBanner();
            // Console.WriteLine("\n");
            await ToolKitX.DisplayToolkit();
            await GetScan();
        }

        public static async Task Miscellaneous()
        {
            string _iptotest = "127.0.0.1";
            // await Logo.Banner();
            // await WinMapUtils.WinScan.ScanIP("127.0.0.1");
            for (var s = 0; s < 50; s++)
            {
                await WinMapUtils.WinScan.ScanIP(_iptotest, 69);
                Console.ReadKey();
            }
        }

        public static async Task GetScan(){
            // Console.Read
            Console.Write("[!] Enter IP to check: ");
            string? _ipToCheck = Console.ReadLine();
            // int? _portToCheck = Console.ReadLine();
            Console.Write("[!] Enter Port to check: ");
            int _portToCheck = Convert.ToInt32(Console.ReadLine());
            #pragma warning disable CS8604
            await WinMapUtils.WinScan.ScanIP(_ipToCheck, _portToCheck);
            // Console.WriteLine(_ipToCheck);
            await GetScan();
        }
    }
}
