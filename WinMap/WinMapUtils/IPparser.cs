using System;
using System.Linq;

namespace WinMapUtils
{
    public class IPParser
    {
        // Individual octets
        public int Octet1 { get; private set; }
        public int Octet2 { get; private set; }
        public int Octet3 { get; private set; }
        public int Octet4 { get; private set; }

        // Combined octet strings
        public string FirstOctetString { get; private set; }      // "123"
        public string SecondOctetString { get; private set; }     // "123.123"
        public string ThirdOctetString { get; private set; }      // "123.123.123"
        public string FourthOctetString { get; private set; }     // "123.123.123.123"

        // Subnet base (without last octet)
        public string SubnetBase { get; private set; }            // "123.123.123"

        // Full IP
        public string FullIP { get; private set; }                // "123.123.123.123"

        // Constructor - parses IP on creation
        public IPParser(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                throw new ArgumentException("IP address cannot be empty");
            }

            ParseIP(ipAddress);
        }

        private void ParseIP(string ipAddress)
        {
            // Split by dots
            string[] octets = ipAddress.Split('.');

            if (octets.Length != 4)
            {
                throw new FormatException($"Invalid IP format: {ipAddress}");
            }

            // Parse each octet
            try
            {
                Octet1 = int.Parse(octets[0]);
                Octet2 = int.Parse(octets[1]);
                Octet3 = int.Parse(octets[2]);
                Octet4 = int.Parse(octets[3]);
            }
            catch (Exception)
            {
                throw new FormatException($"Invalid IP format: {ipAddress}");
            }

            // Validate octets (0-255)
            if (!IsValidOctet(Octet1) || !IsValidOctet(Octet2) || 
                !IsValidOctet(Octet3) || !IsValidOctet(Octet4))
            {
                throw new FormatException($"Octets must be between 0-255: {ipAddress}");
            }

            // Build progressive strings
            FirstOctetString = $"{Octet1}";
            SecondOctetString = $"{Octet1}.{Octet2}";
            ThirdOctetString = $"{Octet1}.{Octet2}.{Octet3}";
            FourthOctetString = $"{Octet1}.{Octet2}.{Octet3}.{Octet4}";

            // Subnet base (first 3 octets)
            SubnetBase = ThirdOctetString;

            // Full IP
            FullIP = FourthOctetString;
        }

        private bool IsValidOctet(int octet)
        {
            return octet >= 0 && octet <= 255;
        }

        // Method to display all parsed values
        public void DisplayParsedValues()
        {
            Console.WriteLine("\n╔════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     IP PARSER - PARSED VALUES      ║");
            Console.ResetColor();
            Console.WriteLine("╚════════════════════════════════════╝\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("► Individual Octets:");
            Console.ResetColor();
            Console.WriteLine($"  Octet 1: {Octet1}");
            Console.WriteLine($"  Octet 2: {Octet2}");
            Console.WriteLine($"  Octet 3: {Octet3}");
            Console.WriteLine($"  Octet 4: {Octet4}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n► Progressive Octet Strings:");
            Console.ResetColor();
            Console.WriteLine($"  1st Octet String: {FirstOctetString}");
            Console.WriteLine($"  2nd Octet String: {SecondOctetString}");
            Console.WriteLine($"  3rd Octet String: {ThirdOctetString}");
            Console.WriteLine($"  4th Octet String: {FourthOctetString}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n► Network Info:");
            Console.ResetColor();
            Console.WriteLine($"  Subnet Base:      {SubnetBase}");
            Console.WriteLine($"  Full IP:          {FullIP}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✓ Ready to scan {SubnetBase}.1-255");
            Console.ResetColor();
            Console.WriteLine();
        }

        // Generate IP for scanning (subnet base + host number)
        public string GenerateIPForHost(int hostNumber)
        {
            if (hostNumber < 1 || hostNumber > 255)
            {
                throw new ArgumentException("Host number must be 1-255");
            }

            return $"{SubnetBase}.{hostNumber}";
        }
    }
}
