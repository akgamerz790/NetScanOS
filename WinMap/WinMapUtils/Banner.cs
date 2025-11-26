using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using System.Text.Encodings;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Runtime.Versioning;

namespace WinMapUtils
{
    [SupportedOSPlatform("windows")]
    public class Banner
    {
        string _placeholderText =
            "══════════════════════════════════════════════════════════════════════════════════════════════";
        public static void ShowBanner()
        {
            string _bannerText = 
            "██╗    ██╗██╗███╗   ██╗███████╗ ██████╗ █████╗ ███╗   ██╗██╗   ██╗████████╗██╗██╗     ███████╗" +"|" +  "1" + "\n" +
            "██║    ██║██║████╗  ██║██╔════╝██╔════╝██╔══██╗████╗  ██║██║   ██║╚══██╔══╝██║██║     ██╔════╝" +"|" +  "01" + "\n" +
            "██║ █╗ ██║██║██╔██╗ ██║███████╗██║     ███████║██╔██╗ ██║██║   ██║   ██║   ██║██║     ███████╗" +"|" +  "110" + "\n" +
            "██║███╗██║██║██║╚██╗██║╚════██║██║     ██╔══██║██║╚██╗██║██║   ██║   ██║   ██║██║     ╚════██║" +"|" +  "1010" + "\n" +
            "╚███╔███╔╝██║██║ ╚████║███████║╚██████╗██║  ██║██║ ╚████║╚██████╔╝   ██║   ██║███████╗███████║" +"|" +  "01101" + "\n" +
            " ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝╚══════╝╚══════╝" +"|" +  "110110" + "\n" +
            "[!] NetWork ScannerUtil by @akgamerz_790     ════════════════════    [-]  GitHub: akgamerz790/NetScanOS" +"|" +  "11101" + "\n";
            
            string _placeholderText =
            "══════════════════════════════════════════════════════════════════════════════════════════════";


            Console.Clear();
            Console.Write(_bannerText);
            Console.Write("\n");
            // WinMap.WinScan.WriteWithPreset(_placeholderText, true);
            Console.Write(_placeholderText);
        }
    }
}