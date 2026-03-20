using System;
using System.Threading;
using Swed64;

namespace VoicemeeterCooldownBypass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking for voicemeeter8.exe...");
            try
            {
                Swed swed = new Swed("voicemeeter8");
                Console.WriteLine("Successfully attached!");
                IntPtr moduleBase = swed.GetModuleBase("voicemeeter8.exe");
                IntPtr targetAddress = moduleBase + 0x13B518;
                Console.WriteLine("Press Ctrl+C to stop");
                while (true)
                {
                    swed.WriteInt(targetAddress, 1);
                    Thread.Sleep(100); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not attach to VoiceMeeter.");
                Console.WriteLine("Make sure it is running and try running this tool as Administrator");
                Console.WriteLine($"Error Details: {ex.Message}");
            }
            
            Console.ReadLine();
        }
    }
}