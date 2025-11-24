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
    public class Logo
    {
        public static void Banner()
        {
            string _bannerText = 
            "██╗    ██╗██╗███╗   ██╗███████╗ ██████╗ █████╗ ███╗   ██╗██╗   ██╗████████╗██╗██╗     ███████╗" + "\n" +
            "██║    ██║██║████╗  ██║██╔════╝██╔════╝██╔══██╗████╗  ██║██║   ██║╚══██╔══╝██║██║     ██╔════╝" + "\n" +
            "██║ █╗ ██║██║██╔██╗ ██║███████╗██║     ███████║██╔██╗ ██║██║   ██║   ██║   ██║██║     ███████╗" + "\n" +
            "██║███╗██║██║██║╚██╗██║╚════██║██║     ██╔══██║██║╚██╗██║██║   ██║   ██║   ██║██║     ╚════██║" + "\n" +
            "╚███╔███╔╝██║██║ ╚████║███████║╚██████╗██║  ██║██║ ╚████║╚██████╔╝   ██║   ██║███████╗███████║" + "\n" +
            " ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝╚══════╝╚══════╝" + "\n" +
            "[!] NetWork ScannerUtil by @akgamerz_790     ════════════════════    [-]  GitHub: akgamerz790 |" + "\n";
            
            Console.Clear();
            Console.WriteLine(_bannerText);
        }
    }
}