using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Versioning;

namespace WinMapUtils
{
    public class Scan
    {
        public async static Task ScanXYZ(string _ipSend)
        {
            for (var s = 0; s < 256; s++)
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(_ipSend, VariableSpace.FallBackVars._THOUSANDINTEGER);
                if (reply.Status == IPStatus.Success)
                {
                    await PortSTUFF.CheckForPorts(_ipSend);
                }
            }
        }

        public class PortSTUFF{
            public async static Task CheckForPorts(string _ip19)
            {
                TcpClient tcpClient = new TcpClient();

                // tcpClient.Connect(_ip19, );
                for (int s = 0; s < 65536; s++) // s++
                {
                    tcpClient.Connect(_ip19, s);
                    
                   if (await IsPortOpen(_ip19, s))
                    {
                        Console.WriteLine($"    [+] Port {s} is open");
                    }
                }
            }

            public async static Task<bool> IsPortOpen(string _hostStatCheck, int _PortCheck)
            {
                using var client = new TcpClient();
                var result = client.BeginConnect(_hostStatCheck, _PortCheck, null, null);
                var success = result.AsyncWaitHandle.WaitOne(VariableSpace.FallBackVars._THOUSANDINTEGER);
                client.EndConnect(result);
                return success;
            }
        }
    }
}