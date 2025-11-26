using System;
using System.Linq;

namespace WinMapUtils
{
    public static class IPEncoder
    {
        // Direct static methods - call with IP string, get what you need

        // Get individual octets
        public static int GetOctet1(string ip) => ParseIP(ip)[0];
        public static int GetOctet2(string ip) => ParseIP(ip)[1];
        public static int GetOctet3(string ip) => ParseIP(ip)[2];
        public static int GetOctet4(string ip) => ParseIP(ip)[3];

        // Get progressive octet strings
        public static string GetFirstOctetString(string ip)
        {
            var octets = ParseIP(ip);
            return $"{octets[0]}";
        }

        public static string GetSecondOctetString(string ip)
        {
            var octets = ParseIP(ip);
            return $"{octets[0]}.{octets[1]}";
        }

        public static string GetThirdOctetString(string ip)
        {
            var octets = ParseIP(ip);
            return $"{octets[0]}.{octets[1]}.{octets[2]}";
        }

        public static string GetFourthOctetString(string ip)
        {
            var octets = ParseIP(ip);
            return $"{octets[0]}.{octets[1]}.{octets[2]}.{octets[3]}";
        }

        // Get subnet base (first 3 octets)
        public static string GetSubnetBase(string ip)
        {
            var octets = ParseIP(ip);
            return $"{octets[0]}.{octets[1]}.{octets[2]}";
        }

        // Get full IP (validated)
        public static string GetFullIP(string ip)
        {
            var octets = ParseIP(ip);
            return $"{octets[0]}.{octets[1]}.{octets[2]}.{octets[3]}";
        }

        // Generate IP from subnet base + host number
        public static string GenerateIP(string subnetBase, int hostNumber)
        {
            if (hostNumber < 0 || hostNumber > 255)
                throw new ArgumentException("Host number must be 0-255");

            return $"{subnetBase}.{hostNumber}";
        }

        // Get CIDR notation
        public static string GetCIDR(string ip)
        {
            return $"{GetSubnetBase(ip)}.0/24";
        }

        // Get IP range
        public static string GetIPRange(string ip)
        {
            string subnet = GetSubnetBase(ip);
            return $"{subnet}.1 - {subnet}.255";
        }

        // Get all IPs in subnet as array
        public static string[] GetAllSubnetIPs(string ip)
        {
            string subnet = GetSubnetBase(ip);
            string[] ips = new string[255];
            
            for (int i = 1; i <= 255; i++)
            {
                ips[i - 1] = $"{subnet}.{i}";
            }
            
            return ips;
        }

        // Display parsed info (useful for debugging)
        public static void DisplayInfo(string? ip)
        {
            var octets = ParseIP(ip);
            
            Console.WriteLine("\n╔════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     IP PARSER - PARSED VALUES      ║");
            Console.ResetColor();
            Console.WriteLine("╚════════════════════════════════════╝\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("► Individual Octets:");
            Console.ResetColor();
            Console.WriteLine($"  Octet 1: {octets[0]}");
            Console.WriteLine($"  Octet 2: {octets[1]}");
            Console.WriteLine($"  Octet 3: {octets[2]}");
            Console.WriteLine($"  Octet 4: {octets[3]}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n► Progressive Strings:");
            Console.ResetColor();
            Console.WriteLine($"  1st: {GetFirstOctetString(ip)}");
            Console.WriteLine($"  2nd: {GetSecondOctetString(ip)}");
            Console.WriteLine($"  3rd: {GetThirdOctetString(ip)}");
            Console.WriteLine($"  4th: {GetFourthOctetString(ip)}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n► Network Info:");
            Console.ResetColor();
            Console.WriteLine($"  Subnet:  {GetSubnetBase(ip)}");
            Console.WriteLine($"  CIDR:    {GetCIDR(ip)}");
            Console.WriteLine($"  Range:   {GetIPRange(ip)}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✓ Ready to scan {GetSubnetBase(ip)}.1-255");
            Console.ResetColor();
            Console.WriteLine();
        }

        // Core parsing method (private)
        private static int[] ParseIP(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                throw new ArgumentException("IP address cannot be empty");

            string[] parts = ip.Trim().Split('.');

            if (parts.Length != 4)
                throw new FormatException($"Invalid IP format: {ip}");

            int[] octets = new int[4];

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(parts[i], out octets[i]))
                    throw new FormatException($"Invalid octet: {parts[i]}");

                if (octets[i] < 0 || octets[i] > 255)
                    throw new FormatException($"Octet must be 0-255: {octets[i]}");
            }

            return octets;
        }

        // Validate IP without throwing exception
        public static bool IsValidIP(string ip)
        {
            try
            {
                ParseIP(ip);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
