using System;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Net.NetworkInformation;

namespace WinMapUtils
{
    public class WinUtils
    {

        public static void LineBreak()
        {
            // Console.WriteLine("Local IP: " + GetLocalIPAddress());
            string _lineBreakModifier = "\n";
            Console.Write(_lineBreakModifier);
        }
        public async static Task GetLocalIP()
        {
            

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static void GetAllLocalIPAddresses()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine($"IPv4: {ip}");
                }
                else if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    Console.WriteLine($"IPv6: {ip}");
                }
            }
        }
        public static class NetworkHelper
        {
            public static List<string> GetAllLocalIPAddresses()
            {
                var ipAddresses = new List<string>();
                var host = Dns.GetHostEntry(Dns.GetHostName());
                
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipAddresses.Add($"IPv4: {ip}");
                    }
                    else if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        ipAddresses.Add($"IPv6: {ip}");
                    }
                }
                
                return ipAddresses;
            }
        }
    }



public static class WiFiHelper
{
    public static string GetConnectedWiFiName()
    {
        try
        {
            var wifiInterface = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up &&
                                     (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                                      ni.Name.ToLower().Contains("wireless") ||
                                      ni.Name.ToLower().Contains("wifi") ||
                                      ni.Description.ToLower().Contains("wireless") ||
                                      ni.Description.ToLower().Contains("wi-fi")));

            return wifiInterface?.Name ?? "No WiFi connection found";
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}

    public class GetNetWorkinfo()
    {
        
        string GetLocalIPAddress()
{
    foreach (var iface in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
    {
        if (iface.AddressFamily == AddressFamily.InterNetwork)
            return iface.ToString();
        }

            throw new Exception("No IPv4 address found.");
        }

//________________________________________________________________________________________________

        public static string NetworkName()
        {
            try
            {
                var wifiInterface = NetworkInterface.GetAllNetworkInterfaces()
                    .FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up &&
                                        ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);

                return wifiInterface?.Name ?? "No WiFi Connected";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}