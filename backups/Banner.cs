using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using System.Text.Encodings;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace WinMapUtils
{
    public class Banner
    {
        string _placeholderText =
            "══════════════════════════════════════════════════════════════════════════════════════════════";
        public static void ShowBanner()
        {
            string _bannerText = 
            "██╗    ██╗██╗███╗   ██╗███████╗ ██████╗ █████╗ ███╗   ██╗██╗   ██╗████████╗██╗██╗     ███████╗" +"|" + "111011" + "\n" +
            "██║    ██║██║████╗  ██║██╔════╝██╔════╝██╔══██╗████╗  ██║██║   ██║╚══██╔══╝██║██║     ██╔════╝" +"|" + "101010" + "\n" +
            "██║ █╗ ██║██║██╔██╗ ██║███████╗██║     ███████║██╔██╗ ██║██║   ██║   ██║   ██║██║     ███████╗" +"|" +  "100110" + "\n" +
            "██║███╗██║██║██║╚██╗██║╚════██║██║     ██╔══██║██║╚██╗██║██║   ██║   ██║   ██║██║     ╚════██║" +"|" +  "110010" + "\n" +
            "╚███╔███╔╝██║██║ ╚████║███████║╚██████╗██║  ██║██║ ╚████║╚██████╔╝   ██║   ██║███████╗███████║" +"|" +  "110001" + "\n" +
            " ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝╚══════╝╚══════╝" +"|" +  "1100101" + "\n" +
            "[!] NetWork ScannerUtil by @akgamerz_790     ════════════════════    [-]  GitHub: akgamerz790/NetScanOS" +"|" +  "11101" + "\n";
            
            string _placeholderText =
            "══════════════════════════════════════════════════════════════════════════════════════════════";

1      
01     
110    
1010   
01101  
110110 
1010101

            Console.Clear();
            Console.Write(_bannerText);
            Console.Write(_placeholderText);
        }
    }
}