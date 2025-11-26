using WinMapUtils;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using VariableSpace;
using System.Security;
using System.Net.NetworkInformation;

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
            // await TextUtils.TextStyler("12");
            await ToolKitX.DisplayToolkit();
            // string[] g = IPEncoder.GetAllSubnetIPs("1.1.1.1");
            // Console.WriteLine(g);

            
            Console.WriteLine("HI");
            await WriteWithPreset((ConsoleColor)FallBackVars.ConsoleColorPresets.ColorPresets.Error, "56", true);
            // await Miscellaneous("enderblade.com");
            

            await GetScan();
        }


        public async static Task WriteWithPreset(ConsoleColor preset, string text, bool appendNewLine)
        {
            // ApplyPreset expects a tuple (FG, BG) so pass the preset as FG and keep current background
            VariableSpace.FallBackVars.ConsoleColorPresets.ApplyPreset((preset, Console.BackgroundColor));

            if (appendNewLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }
            Console.ResetColor();
        }


        public static async Task Miscellaneous(string _ipTest)
        {
            string _iptotest = "google.com";
            if (_ipTest != null)
            {
                for (var _s = 0; _s < 256; _s++)
                {
                    await WinMapUtils.WinScan.ScanIP(_ipTest, _s, 99);
                }
            }
            else
            {
                for (var _s = 0; _s < 50; _s++)
                {
                    await WinMapUtils.WinScan.ScanIP(_iptotest, _s, 0);
                }
            }
        }

        public static async Task GetScan(){
            // Console.Read
            Console.Write("[!] Enter IP to check: ");
            string? _ipToCheck = Console.ReadLine();
                #pragma warning disable CS8604 // Possible null reference argument.
            string? _IPSUBNET = IPEncoder.GetSubnetBase(_ipToCheck);
                #pragma warning restore CS8604 // Possible null reference argument.
            Console.WriteLine("[!] IP Subnet: " +_IPSUBNET);


            // int? _portToCheck = Console.ReadLine();
            Console.Write("[!] Enter Port to check: ");
            int _portToCheck = Convert.ToInt32(Console.ReadLine());
            #pragma warning disable CS8604
            await TextUtils.TextStyler(_ipToCheck, FallBackVars.ScanTypes._ARP_SCAN, 67, _portToCheck);
            await WinMapUtils.WinScan.ScanIP(_ipToCheck, _portToCheck, 9);
            // await GetScan(); //Not needed  [ADDED NEW SCAN HANDLING]
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
