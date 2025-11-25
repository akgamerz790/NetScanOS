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
            // await TextUtils.TextStyler("12");
            await ToolKitX.DisplayToolkit();

            
            Console.WriteLine("HI");
            WriteWithPreset((ConsoleColor)FallBackVars.ConsoleColorPresets.ColorPresets.Error, "56", true);
            await GetScan();
        }

        // public static void WriteWithPreset(string _text56, bool _appendNewLine)
        // {
        //     FallBackVars.ConsoleColorPresets.ApplyPreset(FallBackVars.ConsoleColorPresets._PRESET_SUCCESS);
        //     if(_appendNewLine == true)
        //     {
        //         Console.WriteLine(_text56);
        //         // Console.ResetColor();
        //     }
        //     else   //ResetColor() not needed when sepcified outBound of IF/ELSE
        //     {
        //         Console.Write(_text56);
        //         // Console.ResetColor();
        //     }
        //     Console.ResetColor();
        // }

        public static void WriteWithPreset(ConsoleColor preset, string text, bool appendNewLine)
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
            await TextUtils.TextStyler(_ipToCheck, FallBackVars.ScanTypes._ARP_SCAN, 67, _portToCheck);
            await WinMapUtils.WinScan.ScanIP(_ipToCheck, _portToCheck);
            // Console.WriteLine(_ipToCheck);
            await GetScan();
        }
    }
}
