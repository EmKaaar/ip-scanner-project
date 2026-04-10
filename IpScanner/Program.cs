using System.Net.NetworkInformation;

namespace IpScanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start-IP: ");
            string start = Console.ReadLine();

            Console.Write("End-IP: ");
            string end = Console.ReadLine();

            Console.WriteLine($"Start: {start}");
            Console.WriteLine($"Ende: {end}");

            bool reachable = Ping(start);
            Console.WriteLine(reachable ? "Start-IP erreichbar" : "Start-IP nicht erreichbar");

        }

        public static bool Ping(string ip)
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send(ip, 1000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
    }   

    }