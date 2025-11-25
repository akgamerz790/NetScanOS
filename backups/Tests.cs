using System;
using System.Net;
using System.Net.Sockets;

namespace WinMapUtils
{
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
}
