using System;
using System.Net.Sockets;

namespace WinMapUtils
{
    public class PortScan
    {

        public static async Task CheckForPort(string _ip7, int _port7)
        {
            TcpClient client = new();
            try
            {
                var result = client.BeginConnect(_ip7, _port7, null, null);
                var success = result.AsyncWaitHandle.WaitOne(1000);
                if(success) client.EndConnect(result);
                
                if(success){
                    Console.WriteLine("[!] Port " + _port7 + " is open...");
                }
                else{
                    Console.WriteLine("[!] Port " + _port7 + " is closed...");
                }
            }
            catch{
                Console.WriteLine("[!] Port " + _port7 + " is closed...");
            }
        }

        public static async Task CheckPort(string _ip, int _port)
        {
            try
            {
                using var client = new TcpClient();
                var result = client.BeginConnect(_ip, _port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(1000);
                if (success) client.EndConnect(result);
            }
            catch {Console.WriteLine("hi");}
        }
        public static bool IsPortOpen(string host, int port, int timeout = 1000)
        {
            try
            {
                using var client = new TcpClient();
                var result = client.BeginConnect(host, port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(timeout);
                client.EndConnect(result);
                return success;
            }
            catch
            {
                return false;
            }
        }

        public async static Task CheckPortX(string _ip, int _port)
        {
            // After ping succeeds
            // if (PingHost(_ip))
            if(true)
            {
                Console.WriteLine($"[+] Host {_ip} is up");
                
                // Add port scanning here
                int[] commonPorts = {21, 22, 23, 80, 443, 2121, 8080};
                foreach(int port in commonPorts)
                {
                    if (IsPortOpen(_ip, port))
                    {
                        Console.WriteLine($"    [+] Port {port} is open");
                    }
                }
            }
            else
            {
                #pragma warning disable CS0162 // Unreachable code detected
                    Console.WriteLine($"[-] Host {_ip} is down");
                #pragma warning restore CS0162 // Unreachable code detected
            }
        }
    }
}